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
        public int ArticleID { get; set; }
        public int WarehouseID { get; set; }
        public int Quantity { get; set; }
        public StockMovementType Type { get; set; }
        public DateTime MovementDate { get; set; } = DateTime.UtcNow;

        [JsonIgnore]
        public Article? Article { get; set; }
        [JsonIgnore]
        public Warehouse? Warehouse { get; set; }
    }
}
