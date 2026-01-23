using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.InvoiceRepo
{
    public interface IInvoiceRepository
    {
        Task<List<Invoice>> GetInvoices();
        Task<Invoice> GetInvoice(int id);
        Task<Invoice> AddInvoice(Invoice invoice);
        Task<Invoice> UpdateInvoice(Invoice invoice);
        Task DeleteInvoice(int id);
    }
}
