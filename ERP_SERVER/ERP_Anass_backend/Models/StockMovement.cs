using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public enum StockMovementType
    {
        Purchase,
        Sale,
        Adjustment,
        Transfer
    }

    public class StockMovement
    {
        [Key]
        public int idStockMovement { get; set; }
        // Removed ArticleID and Quantity from Header
        public int WarehouseID { get; set; }
        public StockMovementType Type { get; set; }
        public DateTime MovementDate { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        public Warehouse? Warehouse { get; set; }
        
        public ICollection<StockMovementDetails>? StockMovementDetails { get; set; }
    }
}
