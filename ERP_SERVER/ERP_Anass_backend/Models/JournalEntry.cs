using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public enum JournalEntryStatus
    {
        Draft,
        Posted
    }

    public class JournalEntry : BaseEntity
    {
        [Key]
        public int idJournalEntry { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.UtcNow;
        public string Description { get; set; }
        public float TotalDebit { get; set; }
        public float TotalCredit { get; set; }
        public JournalEntryStatus Status { get; set; } = JournalEntryStatus.Draft;

        public ICollection<JournalDetails> JournalDetails { get; set; }
    }
}
