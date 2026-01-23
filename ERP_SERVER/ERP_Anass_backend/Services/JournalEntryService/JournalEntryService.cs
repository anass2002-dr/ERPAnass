using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.JournalEntryRepo;

namespace ERP_Anass_backend.Services.JournalEntryService
{
    public class JournalEntryService : IServiceJournalEntry
    {
        private readonly IRepoJournalEntry _repoJournalEntry;

        public JournalEntryService(IRepoJournalEntry repoJournalEntry)
        {
            _repoJournalEntry = repoJournalEntry;
        }

        public JournalEntry AddJournalEntry(JournalEntryDtos entryDtos)
        {
            // Validation: Debit must equal Credit
            float totalDebit = entryDtos.JournalDetails.Sum(d => d.DebitAmount);
            float totalCredit = entryDtos.JournalDetails.Sum(d => d.CreditAmount);

            if (Math.Abs(totalDebit - totalCredit) > 0.01) // Floating point tolerance
            {
                throw new InvalidOperationException($"Journal Entry is not balanced. Total Debit: {totalDebit}, Total Credit: {totalCredit}");
            }

            JournalEntry entry = new JournalEntry();
            entry.EntryDate = entryDtos.EntryDate;
            entry.Description = entryDtos.Description;
            entry.Status = entryDtos.Status;
            entry.TotalDebit = totalDebit;
            entry.TotalCredit = totalCredit;
            
            entry.JournalDetails = new List<JournalDetails>();
            foreach (var d in entryDtos.JournalDetails)
            {
                entry.JournalDetails.Add(new JournalDetails
                {
                    AccountID = d.AccountID,
                    DebitAmount = d.DebitAmount,
                    CreditAmount = d.CreditAmount,
                    Description = d.Description
                });
            }

            return _repoJournalEntry.AddJournalEntry(entry);
        }

        public bool DeleteJournalEntry(int id)
        {
            return _repoJournalEntry.DeleteJournalEntry(id);
        }

        public JournalEntry GetJournalEntryById(int id)
        {
            return _repoJournalEntry.GetJournalEntryById(id);
        }

        public List<JournalEntry> GetJournalEntries()
        {
            return _repoJournalEntry.GetJournalEntries();
        }

        public JournalEntry UpdateJournalEntry(int id, JournalEntry entry)
        {
            entry.idJournalEntry = id;
            return _repoJournalEntry.UpdateJournalEntry(entry);
        }
    }
}
