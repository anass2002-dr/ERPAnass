using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class StockMovementDtos
    {
        public int idStockMovement { get; set; }
        [DefaultValue(0)]
        public int ArticleID { get; set; }
        [DefaultValue(0)]
        public int WarehouseID { get; set; }
        [DefaultValue(0)]
        public int Quantity { get; set; }
        public StockMovementType Type { get; set; }
        public DateTime MovementDate { get; set; }

        public StockMovementDtos(StockMovement stockMovement)
        {
            this.idStockMovement = stockMovement.idStockMovement;
            this.ArticleID = stockMovement.ArticleID;
            this.WarehouseID = stockMovement.WarehouseID;
            this.Quantity = stockMovement.Quantity;
            this.Type = stockMovement.Type;
            this.MovementDate = stockMovement.MovementDate;
        }
        public StockMovementDtos() { }
    }
}
