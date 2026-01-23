using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.DTOs
{
    public class BankAccountDto : BaseEntity
    {
        public int idBankAccount { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public decimal CurrentBalance { get; set; }
    }

    public class BankAccountCreateDto
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
