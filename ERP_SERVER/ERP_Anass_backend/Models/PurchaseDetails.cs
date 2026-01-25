using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class PurchaseDetails : BaseEntity
    {
        [Key]
        public int IdPurchaseDetails { get; set; }

        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TaxAmount { get; set; }
        public string? Quality { get; set; }
        // IsActive inherited

        public int? idArticle { get; set; }
        [JsonIgnore]
        public Article? Article { get; set; }

        public int? IdPurchase { get; set; }
        [JsonIgnore]
        public Purchase? Purchase { get; set; }

        public int? idTaxConfig { get; set; }
        [JsonIgnore]
        public TaxConfiguration? TaxConfig { get; set; }

        public string? LineItemStatus { get; set; }
        public string? UnitOfMeasure { get; set; }
        public decimal? LineDiscountAmount { get; set; }
        public decimal? LineDiscountPercentage { get; set; }
        public string? BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? SerialNumber { get; set; }
        public string? WarehouseLocation { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public decimal? RejectedQuantity { get; set; }
        public decimal? LineTaxRate { get; set; } // Kept for historical record if tax config changes
    }
}
