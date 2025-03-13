using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Purchase
    { 
        [Key]
        public int IdPurchase { get; set; }
        public string PurchaseRef { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Remarks { get; set; }

        public Boolean IsAcitve { get; set; }
        public int? idSupplier { get; set; }
        [JsonIgnore]
        public Supplier? Supplier { get; set; }
        public int? IdCurrency { get; set; }
        [JsonIgnore]
        public Currency? Currencyobj { get; set; }


        [JsonIgnore]
        public ICollection<PurchaseDetails> PurchaseDetails { get; set; } = [];
    }
}
