using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class JournalDetails : BaseEntity
    {
        [Key]
        public int idJournalDetails { get; set; }
        public int JournalEntryID { get; set; }
        public int AccountID { get; set; }
        public float DebitAmount { get; set; }
        public float CreditAmount { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public JournalEntry? JournalEntry { get; set; }
        [JsonIgnore]
        public Account? Account { get; set; }
    }
}
