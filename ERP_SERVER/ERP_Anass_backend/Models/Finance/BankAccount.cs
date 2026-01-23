using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class BankAccount : BaseEntity
    {
        [Key]
        public int idBankAccount { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public decimal CurrentBalance { get; set; }
        
        public int? idAccount { get; set; }
        [ForeignKey("idAccount")]
        [JsonIgnore]
        public Account? Account { get; set; }
    }
}
