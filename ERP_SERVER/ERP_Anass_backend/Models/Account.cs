using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public enum AccountType
    {
        Asset,
        Liability,
        Equity,
        Income,
        Expense
    }

    public class Account
    {
        [Key]
        public int idAccount { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public AccountType Type { get; set; }
        public Boolean IsAcitve { get; set; } = true;
    }
}
