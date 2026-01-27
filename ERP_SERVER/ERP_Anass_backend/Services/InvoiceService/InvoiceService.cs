using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.InvoiceRepo;
using ERP_Anass_backend.Repository.PurchaseRepo;
using ERP_Anass_backend.Repository.SaleRepo;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace ERP_Anass_backend.Services.InvoiceService
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _repository;
        private readonly ISaleRepo _saleRepo;
        private readonly IPurchaseRepo _purchaseRepo;

        public InvoiceService(IInvoiceRepository repository, ISaleRepo saleRepo, IPurchaseRepo purchaseRepo)
        {
            _repository = repository;
            _saleRepo = saleRepo;
            _purchaseRepo = purchaseRepo;
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
                    TaxRate = d.LineTaxRate ?? 0m,
                    Total = d.TotalPrice ?? 0m
                }).ToList()
            };

            var created = await _repository.AddInvoice(invoice);
            return await GetInvoice(created.idInvoice);
        }

        public async Task<byte[]> GeneratePdf(int invoiceId)
        {
            var invoice = await _repository.GetInvoice(invoiceId);
            if (invoice == null) throw new KeyNotFoundException("Invoice not found");

            // QuestPDF Layout
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(11));

                    page.Header()
                        .Text($"Invoice #{invoice.InvoiceNumber}")
                        .SemiBold().FontSize(20).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Item().Text($"Date: {invoice.IssueDate:d}");
                            x.Item().Text($"Due Date: {invoice.DueDate:d}");
                            x.Item().Text($"Type: {invoice.InvoiceType}");
                            
                            x.Item().PaddingTop(10).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                            x.Item().PaddingTop(10).Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3); // Item
                                    columns.RelativeColumn();  // Qty
                                    columns.RelativeColumn();  // Price
                                    columns.RelativeColumn();  // Total
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Element(CellStyle).Text("Item");
                                    header.Cell().Element(CellStyle).Text("Quantity");
                                    header.Cell().Element(CellStyle).Text("Price");
                                    header.Cell().Element(CellStyle).Text("Total");

                                    static IContainer CellStyle(IContainer container)
                                    {
                                        return container.DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                                    }
                                });

                                foreach (var item in invoice.InvoiceDetails)
                                {
                                    table.Cell().Element(CellStyle).Text($"Item #{item.ArticleId}"); 
                                    table.Cell().Element(CellStyle).Text($"{item.Quantity}");
                                    table.Cell().Element(CellStyle).Text($"{item.Price:C}");
                                    table.Cell().Element(CellStyle).Text($"{item.Total:C}");

                                    static IContainer CellStyle(IContainer container)
                                    {
                                        return container.BorderBottom(1).BorderColor(Colors.Grey.Medium).PaddingVertical(5);
                                    }
                                }
                            });
                            
                            x.Item().PaddingTop(10).AlignRight().Text($"Total: {invoice.TotalAmount:C}").SemiBold().FontSize(14);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            });

            return document.GeneratePdf();
        }
    }
}
