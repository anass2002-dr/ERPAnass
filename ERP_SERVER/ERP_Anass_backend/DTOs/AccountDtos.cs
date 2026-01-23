using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class AccountDtos
    {
        public int idAccount { get; set; }
        [DefaultValue(null)]
        public string AccountCode { get; set; }
        [DefaultValue(null)]
        public string AccountName { get; set; }
        public AccountType Type { get; set; }
        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }

        public AccountDtos(Account account)
        {
            this.idAccount = account.idAccount;
            this.AccountCode = account.AccountCode;
            this.AccountName = account.AccountName;
            this.Type = account.Type;
            this.IsAcitve = account.IsAcitve;
        }
        public AccountDtos() { }
    }
}
