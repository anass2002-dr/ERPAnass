using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.InvoiceService
{
    public interface IInvoiceService
    {
        Task<List<InvoiceDto>> GetInvoices();
        Task<InvoiceDto> GetInvoice(int id);
        Task<InvoiceDto> CreateInvoice(InvoiceCreateDto invoiceDto);
        Task<InvoiceDto> UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
        Task<InvoicePdfDto> GetInvoicePdfData(int invoiceId);
        
        // Generation Logic
        Task<InvoiceDto> GenerateInvoiceFromSale(int saleId);
        Task<InvoiceDto> GenerateInvoiceFromPurchase(int purchaseId);
        Task<InvoiceDto> GetInvoiceDataFromPurchase(int purchaseId);

    }
}
