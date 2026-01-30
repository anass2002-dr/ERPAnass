using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.InvoiceRepo;
using ERP_Anass_backend.Repository.PurchaseRepo;
using ERP_Anass_backend.Repository.PurchaseRepo;
using ERP_Anass_backend.Repository.SaleRepo;
using ERP_Anass_backend.Repository.TaxConfigurationRepo;
using ERP_Anass_backend.Repository.TenantRepo;

namespace ERP_Anass_backend.Services.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;
        private readonly ISaleRepo _saleRepo;
        private readonly IPurchaseRepo _purchaseRepo;
        private readonly IRepoTenant _tenantRepo;
        private readonly ITaxConfigurationRepo _taxConfigurationRepo;

        public InvoiceService(IInvoiceRepository repository, ISaleRepo saleRepo, IPurchaseRepo purchaseRepo, IRepoTenant tenantRepo, ITaxConfigurationRepo taxConfigurationRepo)
        {
            _repository = repository;
            _saleRepo = saleRepo;
            _purchaseRepo = purchaseRepo;
            _tenantRepo = tenantRepo;
            _taxConfigurationRepo = taxConfigurationRepo;
        }

        public async Task<List<InvoiceDto>> GetInvoices()
        {
            var invoices = await _repository.GetInvoices();
            return invoices.Select(i => new InvoiceDto
            {
                idInvoice = i.idInvoice,
                InvoiceNumber = i.InvoiceNumber,
                IssueDate = i.IssueDate,
                DueDate = i.DueDate,
                TotalAmount = i.TotalAmount,
                TaxAmount = i.TaxAmount,
                Status = i.Status,
                InvoiceType = i.InvoiceType,
                SaleId = i.SaleId,
                CustomerId = i.CustomerId,
                PurchaseId = i.PurchaseId,
                SupplierId = i.SupplierId,
                InvoiceDetails = i.InvoiceDetails.Select(d => new InvoiceDetailDto
                {
                    idInvoiceDetail = d.idInvoiceDetail,
                    Quantity = d.Quantity,
                    Price = d.Price,
                    TaxRate = d.TaxRate,
                    Total = d.Total,
                    InvoiceId = d.InvoiceId,
                    ArticleId = d.ArticleId
                }).ToList()
            }).ToList();
        }

        public async Task<InvoiceDto> GetInvoice(int id)
        {
            var invoice = await _repository.GetInvoice(id);
            if (invoice == null) return null;

            return new InvoiceDto
            {
                idInvoice = invoice.idInvoice,
                InvoiceNumber = invoice.InvoiceNumber,
                IssueDate = invoice.IssueDate,
                DueDate = invoice.DueDate,
                TotalAmount = invoice.TotalAmount,
                TaxAmount = invoice.TaxAmount,
                Status = invoice.Status,
                InvoiceType = invoice.InvoiceType,
                SaleId = invoice.SaleId,
                CustomerId = invoice.CustomerId,
                PurchaseId = invoice.PurchaseId,
                SupplierId = invoice.SupplierId,
                InvoiceDetails = invoice.InvoiceDetails.Select(d => new InvoiceDetailDto
                {
                    idInvoiceDetail = d.idInvoiceDetail,
                    Quantity = d.Quantity,
                    Price = d.Price,
                    TaxRate = d.TaxRate,
                    Total = d.Total,
                    InvoiceId = d.InvoiceId,
                    ArticleId = d.ArticleId
                }).ToList()
            };
        }

        public async Task<InvoiceDto> CreateInvoice(InvoiceCreateDto invoiceDto)
        {
            var invoice = new Invoice
            {
                InvoiceNumber = invoiceDto.InvoiceNumber,
                IssueDate = invoiceDto.IssueDate,
                DueDate = invoiceDto.DueDate,
                TotalAmount = invoiceDto.TotalAmount,
                TaxAmount = invoiceDto.TaxAmount,
                Status = invoiceDto.Status,
                InvoiceType = invoiceDto.InvoiceType,
                SaleId = invoiceDto.SaleId,
                CustomerId = invoiceDto.CustomerId,
                PurchaseId = invoiceDto.PurchaseId,
                SupplierId = invoiceDto.SupplierId,
                InvoiceDetails = invoiceDto.InvoiceDetails.Select(d => new InvoiceDetails
                {
                    Quantity = d.Quantity,
                    Price = d.Price,
                    TaxRate = d.TaxRate,
                    Total = d.Total,
                    ArticleId = d.ArticleId
                }).ToList()
            };

            var createdInvoice = await _repository.AddInvoice(invoice);
            return await GetInvoice(createdInvoice.idInvoice);
        }

        public async Task<InvoiceDto> UpdateInvoice(Invoice invoice)
        {
            var updatedInvoice = await _repository.UpdateInvoice(invoice);
            return await GetInvoice(updatedInvoice.idInvoice);
        }

        public async Task DeleteInvoice(int id)
        {
            await _repository.DeleteInvoice(id);
        }
        public async Task<InvoiceDto> GenerateInvoiceFromSale(int saleId)
        {
            var sale = _saleRepo.GetSaleById(saleId);
            if (sale == null) throw new KeyNotFoundException("Sale not found");

            var invoice = new Invoice
            {
                InvoiceNumber = $"INV-{sale.SaleRef}",
                IssueDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                TotalAmount = sale.TotalAmount ?? 0m,
                TaxAmount = sale.TotalTaxAmount ?? 0m,
                Status = "Open",
                InvoiceType = "Sale",
                SaleId = saleId,
                CustomerId = sale.IdCustomer,
                InvoiceDetails = sale.SaleDetails.Select(d => new InvoiceDetails
                {
                    ArticleId = d.idArticle ?? 0,
                    Quantity = (int)d.Quantity,
                    Price = d.UnitPrice,
                    TaxRate = d.LineTaxRate,
                    Total = d.TotalPrice
                }).ToList()
            };

            var created = await _repository.AddInvoice(invoice);
            return await GetInvoice(created.idInvoice);
        }

        public async Task<InvoiceDto> GenerateInvoiceFromPurchase(int purchaseId)
        {
            var purchase = _purchaseRepo.GetPurchaseById(purchaseId);
            if (purchase == null) throw new KeyNotFoundException("Purchase not found");

            var invoice = new Invoice
            {
                InvoiceNumber = $"BILL-{purchase.PurchaseRef}",
                IssueDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                TotalAmount = purchase.TotalAmount ?? 0m,
                TaxAmount = purchase.TotalTaxAmount ?? 0m,
                Status = "Open",
                InvoiceType = "Purchase",
                PurchaseId = purchaseId,
                SupplierId = purchase.idSupplier,
                InvoiceDetails = purchase.PurchaseDetails.Select(d => new InvoiceDetails
                {
                    ArticleId = d.idArticle ?? 0,
                    Quantity = (int)(d.Quantity ?? 0),
                    Price = d.UnitPrice ?? 0m,
                    TaxRate = (d.idTaxConfig.HasValue 
                        ? (_taxConfigurationRepo.GetTaxConfigurationById(d.idTaxConfig.Value)?.TaxRate ?? 0m) 
                        : (d.LineTaxRate ?? 0m)),
                    Total = d.TotalPrice ?? 0m
                }).ToList()
            };

            var created = await _repository.AddInvoice(invoice);
            return await GetInvoice(created.idInvoice);
        }

        public async Task<InvoiceDto> GetInvoiceDataFromPurchase(int purchaseId)
        {
            var purchase = _purchaseRepo.GetPurchaseById(purchaseId);
            if (purchase == null) throw new KeyNotFoundException("Purchase not found");

            // Return DTO directly without saving
            return new InvoiceDto
            {
                InvoiceNumber = $"BILL-{purchase.PurchaseRef}", // Suggested number
                IssueDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                TotalAmount = purchase.TotalAmount ?? 0m,
                TaxAmount = purchase.TotalTaxAmount ?? 0m,
                Status = "Draft",
                InvoiceType = "Purchase",
                PurchaseId = purchaseId,
                SupplierId = purchase.idSupplier,
                InvoiceDetails = purchase.PurchaseDetails.Select(d => new InvoiceDetailDto
                {
                    ArticleId = d.idArticle ?? 0,
                    Quantity = (int)(d.Quantity ?? 0),
                    Price = d.UnitPrice ?? 0m,
                    TaxRate = (d.idTaxConfig.HasValue 
                        ? (_taxConfigurationRepo.GetTaxConfigurationById(d.idTaxConfig.Value)?.TaxRate ?? 0m) 
                        : (d.LineTaxRate ?? 0m)),
                    Total = d.TotalPrice ?? 0m
                }).ToList()
            };
        }

        // Removed GeneratePdf as rendering is moved to frontend

        public async Task<InvoicePdfDto> GetInvoicePdfData(int invoiceId)
        {
            var invoice = await _repository.GetInvoice(invoiceId);
            if (invoice == null) return null;

            var tenant = _tenantRepo.GetTenantById(invoice.TenantId);

            return new InvoicePdfDto
            {
                idInvoice = invoice.idInvoice,
                InvoiceNumber = invoice.InvoiceNumber,
                IssueDate = invoice.IssueDate,
                DueDate = invoice.DueDate,
                TotalAmount = invoice.TotalAmount,
                TaxAmount = invoice.TaxAmount,
                Status = invoice.Status,
                InvoiceType = invoice.InvoiceType,
                
                Tenant = tenant != null ? new TenantDtos(tenant) : null,
                Customer = invoice.Customer != null ? new CustomerDtos(invoice.Customer) : null,
                Supplier = invoice.Supplier != null ? new SupplierDtos(invoice.Supplier) : null,
                
                InvoiceDetails = invoice.InvoiceDetails.Select(d => new InvoiceDetailPdfDto
                {
                    idInvoiceDetail = d.idInvoiceDetail,
                    // Check Article property name if needed. Assuming Designation or Name.
                    // Fallback to ID if null.
                    ItemName = d.Article != null ? d.Article.ArticleName : $"Item #{d.ArticleId}", 
                    Quantity = d.Quantity,
                    Price = d.Price,
                    TaxRate = d.TaxRate,
                    Total = d.Total
                }).ToList()
            };
        }
    }
}
