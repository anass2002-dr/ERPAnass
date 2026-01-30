using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class StockMovementDtos
    {
        public int idStockMovement { get; set; }
        [DefaultValue(0)]
        public int WarehouseID { get; set; }
        public StockMovementType Type { get; set; }
        public DateTime MovementDate { get; set; }

        public List<StockMovementDetailDto> StockMovementDetails { get; set; }

        public StockMovementDtos() 
        {
            StockMovementDetails = new List<StockMovementDetailDto>();
        }
    }

    public class StockMovementDetailDto
    {
        public int ArticleID { get; set; }
        public int Quantity { get; set; }
    }
}
