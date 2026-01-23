using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.JournalEntryRepo
{
    public class RepoJournalEntry : IRepoJournalEntry
    {
        private readonly DbContextERP _context;
        private readonly ITenantProvider _tenantProvider;

        public RepoJournalEntry(DbContextERP context, ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }

        public JournalEntry AddJournalEntry(JournalEntry entry)
        {
            entry.TenantId = _tenantProvider.CurrentTenantId;
            if (entry.JournalDetails != null)
            {
                foreach (var detail in entry.JournalDetails)
                {
                    detail.TenantId = _tenantProvider.CurrentTenantId;
                }
            }
            
            var added = _context.Set<JournalEntry>().Add(entry);
            _context.SaveChanges();
            return added.Entity;
        }

        public bool DeleteJournalEntry(int id)
        {
            var entry = _context.Set<JournalEntry>()
                .FirstOrDefault(e => e.idJournalEntry == id && e.TenantId == _tenantProvider.CurrentTenantId);
            
            if (entry == null) return false;
            
            // Details cascade delete usually handled by DB, but EF Core explicit load/remove is safer if no Cascade
            // Using Include to be sure if necessary, but typically with FK setup it should be fine.
            // Let's rely on EF Core tracking if loaded or DB cascade.
            
            _context.Set<JournalEntry>().Remove(entry);
            _context.SaveChanges();
            return true;
        }

        public List<JournalEntry> GetJournalEntries()
        {
            return _context.Set<JournalEntry>()
                .Where(e => e.TenantId == _tenantProvider.CurrentTenantId)
                .Include(e => e.JournalDetails)
                .ThenInclude(d => d.Account)
                .OrderByDescending(e => e.EntryDate)
                .ToList();
        }

        public JournalEntry GetJournalEntryById(int id)
        {
             return _context.Set<JournalEntry>()
                .Include(e => e.JournalDetails)
                .ThenInclude(d => d.Account)
                .FirstOrDefault(e => e.idJournalEntry == id && e.TenantId == _tenantProvider.CurrentTenantId);
        }

        public JournalEntry UpdateJournalEntry(JournalEntry entry)
        {
             var existing = GetJournalEntryById(entry.idJournalEntry);
             if (existing != null)
             {
                 existing.Description = entry.Description ?? existing.Description;
                 existing.EntryDate = entry.EntryDate;
                 existing.Status = entry.Status;
                 // Updating Details is complex (add/remove/update lines).
                 // For MVP, we might limit header updates or require full replacement logic.
                 // We'll update header fields primarily here.
                 
                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
