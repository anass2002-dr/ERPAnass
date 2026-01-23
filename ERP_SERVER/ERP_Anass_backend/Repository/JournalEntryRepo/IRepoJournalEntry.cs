using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.JournalEntryRepo
{
    public interface IRepoJournalEntry
    {
        JournalEntry GetJournalEntryById(int id);
        List<JournalEntry> GetJournalEntries();
        JournalEntry AddJournalEntry(JournalEntry entry);
        JournalEntry UpdateJournalEntry(JournalEntry entry);
        bool DeleteJournalEntry(int id);
    }
}
