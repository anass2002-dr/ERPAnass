using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Purchase
    {
        [Key]
        public int IdPurchase { get; set; }
        public string PurchaseRef { get; set; }

        public decimal? TotalAmount { get; set; }
        public decimal? TotalPayment { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }

        public int? idSupplier { get; set; }
        [JsonIgnore]
        public Supplier? Supplier { get; set; }

        public int? IdCurrency { get; set; }
        [JsonIgnore]
        public Currency? Currencyobj { get; set; }

        public string PurchaseStatus { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? PurchaseType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? PaymentTerms { get; set; }
        public string? PurchaseChannel { get; set; }

        [JsonIgnore]
        public ICollection<PurchaseDetails> PurchaseDetails { get; set; } = [];
    }
}
