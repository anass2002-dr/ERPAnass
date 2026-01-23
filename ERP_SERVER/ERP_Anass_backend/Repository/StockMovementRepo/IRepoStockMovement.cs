using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.StockMovementRepo
{
    public interface IRepoStockMovement
    {
        StockMovement GetStockMovementById(int id);
        List<dynamic> GetStockMovementsDetails();
        List<StockMovement> GetStockMovements();
        StockMovement AddStockMovement(StockMovement stockMovement);
        StockMovement UpdateStockMovement(StockMovement stockMovement);
        Boolean DeleteStockMovement(int id);
        List<StockMovement> GetStockMovementsByWarehouse(int warehouseId);
        List<StockMovement> GetStockMovementsByArticle(int articleId);
    }
}
