using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class PurchaseDetails
    {
        [Key]
        public int IdPurchaseDetails { get; set; }
        
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TaxAmount { get; set; }
        public string Quality { get; set; }
        public Boolean IsActive { get; set; }
        public int? idArticle { get; set; }
        [JsonIgnore]
        public Article? Article { get; set; }
        public int? IdPurchase { get; set; }
        [JsonIgnore]
        public Purchase? Purchase { get; set; }
    }
}
