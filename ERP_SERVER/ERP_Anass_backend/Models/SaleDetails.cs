using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class SaleDetails
    {
        [Key]
        public int IdSaleDetails { get; set; }

        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TaxAmount { get; set; }
        public string Quality { get; set; }
        public bool IsActive { get; set; }

        public int? idArticle { get; set; }
        [JsonIgnore]
        public Article? Article { get; set; }

        public int? IdSale { get; set; }
        [JsonIgnore]
        public Sale? Sale { get; set; }

        public string LineItemStatus { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal LineDiscountAmount { get; set; }
        public decimal LineDiscountPercentage { get; set; }
        public string BatchNumber { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string SerialNumber { get; set; }
        public string WarehouseLocation { get; set; }
        public decimal ReceivedQuantity { get; set; }
        public decimal RejectedQuantity { get; set; }
        public decimal LineTaxRate { get; set; }
    }
}
