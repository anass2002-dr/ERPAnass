using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.JournalEntryService
{
    public interface IServiceJournalEntry
    {
        JournalEntry GetJournalEntryById(int id);
        List<JournalEntry> GetJournalEntries();
        JournalEntry AddJournalEntry(JournalEntryDtos entry);
        JournalEntry UpdateJournalEntry(int id, JournalEntry entry);
        bool DeleteJournalEntry(int id);
    }
}
