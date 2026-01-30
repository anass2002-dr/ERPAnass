using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class StockMovementDetails
    {
        [Key]
        public int idStockMovementDetail { get; set; }
        
        public int StockMovementId { get; set; }
        public int ArticleID { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public StockMovement? StockMovement { get; set; }
        [JsonIgnore]
        public Article? Article { get; set; }
    }
}
