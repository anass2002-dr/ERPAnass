using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.InvoiceRepo;

namespace ERP_Anass_backend.Services.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;

        public InvoiceService(IInvoiceRepository repository)
        {
            _repository = repository;
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
    }
}
