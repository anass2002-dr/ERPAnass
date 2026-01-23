using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class JournalEntryDtos
    {
        public int idJournalEntry { get; set; }
        public DateTime EntryDate { get; set; }
        [DefaultValue(null)]
        public string Description { get; set; }
        public float TotalDebit { get; set; }
        public float TotalCredit { get; set; }
        public JournalEntryStatus Status { get; set; }
        public Guid TenantId { get; set; }
        public List<JournalDetailsDtos> JournalDetails { get; set; } = new List<JournalDetailsDtos>();

        public JournalEntryDtos(JournalEntry entry)
        {
            this.idJournalEntry = entry.idJournalEntry;
            this.EntryDate = entry.EntryDate;
            this.Description = entry.Description;
            this.TotalDebit = entry.TotalDebit;
            this.TotalCredit = entry.TotalCredit;
            this.Status = entry.Status;
            this.TenantId = entry.TenantId;
            if (entry.JournalDetails != null)
            {
                this.JournalDetails = entry.JournalDetails.Select(d => new JournalDetailsDtos(d)).ToList();
            }
        }

        public JournalEntryDtos() { }
    }
}
