using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace ERP_Anass_backend.Models
{
    public class Sale
    {

        [Key]
        public int IdSale { get; set; }
        public string SaleRef { get; set; }

        public decimal? TotalAmount { get; set; }
        public decimal? TotalPayment { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Remarks { get; set; }
        public bool? IsActive { get; set; }

        public int? IdCurrency { get; set; }
        [JsonIgnore]
        public Currency? Currencyobj { get; set; }

        public int? IdCustomer { get; set; }
        [JsonIgnore]
        public Customer? Customerobj { get; set; }
        public string SaleStatus { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? SaleType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TotalTaxAmount { get; set; }
        public decimal? ShippingAmount { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? PaymentTerms { get; set; }
        public string? SaleChannel { get; set; }

        [JsonIgnore]
        public ICollection<SaleDetails> SaleDetails { get; set; } = [];
    }
}
