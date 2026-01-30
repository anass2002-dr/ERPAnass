using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.StockMovementService
{
    public interface IServiceStockMovement
    {
        StockMovement GetStockMovementById(int id);
        List<StockMovement> GetStockMovements();
        List<dynamic> GetStockMovementsDetails();
        StockMovement AddStockMovement(StockMovementDtos stockMovement);
        StockMovement UpdateStockMovement(int id, StockMovement stockMovement);
        bool DeleteStockMovement(int id);
        Task<bool> ReceivePurchaseItems(int purchaseId, int warehouseId);
    }
}
