using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.InvoiceRepo
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly DbContextERP _context;

        public InvoiceRepository(DbContextERP context)
        {
            _context = context;
        }

        public async Task<List<Invoice>> GetInvoices()
        {
            return await _context.Invoices
                .Include(i => i.InvoiceDetails).ThenInclude(d => d.Article)
                .Include(i => i.Sale)
                .Include(i => i.Customer)
                .Include(i => i.Purchase)
                .Include(i => i.Supplier)
                .ToListAsync();
        }

        public async Task<Invoice> GetInvoice(int id)
        {
            return await _context.Invoices
                .Include(i => i.InvoiceDetails).ThenInclude(d => d.Article)
                .Include(i => i.Sale)
                .Include(i => i.Customer)
                .Include(i => i.Purchase)
                .Include(i => i.Supplier)
                .FirstOrDefaultAsync(i => i.idInvoice == id);
        }

        public async Task<Invoice> AddInvoice(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task<Invoice> UpdateInvoice(Invoice invoice)
        {
            _context.Entry(invoice).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return invoice;
        }

        public async Task DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
    }
}
