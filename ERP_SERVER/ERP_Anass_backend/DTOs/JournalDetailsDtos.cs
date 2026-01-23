using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class JournalDetailsDtos
    {
        public int idJournalDetails { get; set; }
        public int JournalEntryID { get; set; }
        public int AccountID { get; set; }
        [DefaultValue(0)]
        public float DebitAmount { get; set; }
        [DefaultValue(0)]
        public float CreditAmount { get; set; }
        [DefaultValue(null)]
        public string Description { get; set; }
        public Guid TenantId { get; set; }

        public JournalDetailsDtos(JournalDetails details)
        {
            this.idJournalDetails = details.idJournalDetails;
            this.JournalEntryID = details.JournalEntryID;
            this.AccountID = details.AccountID;
            this.DebitAmount = details.DebitAmount;
            this.CreditAmount = details.CreditAmount;
            this.Description = details.Description;
            this.TenantId = details.TenantId;
        }

        public JournalDetailsDtos() { }
    }
}
