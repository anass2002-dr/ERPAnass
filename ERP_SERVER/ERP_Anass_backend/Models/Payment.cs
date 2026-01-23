using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Payment
    {
        [Key]
        public int idPayment { get; set; }
        public float Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; } // Cash, Check, Transfer, Card
        public string ReferenceNumber { get; set; }

        public int? idCashAccount { get; set; }
        [JsonIgnore]
        public Account? CashAccount { get; set; }

        public int? SaleId { get; set; }
        public int? PurchaseId { get; set; }

        [JsonIgnore]
        public Sale? Sale { get; set; } 
        [JsonIgnore]
        public Purchase? Purchase { get; set; }

        public int? idBankAccount { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("idBankAccount")]
        [JsonIgnore]
        public BankAccount? BankAccount { get; set; }
        
        public int? InvoiceId { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("InvoiceId")]
        [JsonIgnore]
        public Invoice? Invoice { get; set; }
    }
}
