using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.StockMovementRepo;
using ERP_Anass_backend.Repository.ArticleRepo;

namespace ERP_Anass_backend.Services.StockMovementService
{
    public class StockMovementService : IServiceStockMovement
    {
        private readonly IRepoStockMovement _repoStockMovement;
        private readonly IRepoArticle _repoArticle;

        public StockMovementService(IRepoStockMovement repoStockMovement, IRepoArticle repoArticle)
        {
            _repoStockMovement = repoStockMovement;
            _repoArticle = repoArticle;
        }

        public StockMovement AddStockMovement(StockMovementDtos stockMovementDtos)
        {
            StockMovement sm = new StockMovement();
            sm.ArticleID = stockMovementDtos.ArticleID;
            sm.WarehouseID = stockMovementDtos.WarehouseID;
            sm.Quantity = stockMovementDtos.Quantity;
            sm.Type = stockMovementDtos.Type;
            sm.MovementDate = DateTime.UtcNow;

            // Update Article Stock
            // Logic: Sale = Subtract, Others (Purchase, Adjustment, Transfer) = Add
            // Assuming Transfer here means adding to this warehouse? Or is it a net movement?
            // "StockMovement" has one WarehouseID. So it's a record of movement IN or OUT of that warehouse.
            // If Type is Purchase -> IN -> Add
            // If Type is Sale -> OUT -> Subtract
            // If Type is Adjustment -> Could be +/-. Assuming + for now or absolute.
            // If Type is Transfer -> IN?
            
            // Refined Logic based on typical ERP:
            // Purchase: +
            // Sale: -
            
            if (sm.Type == StockMovementType.Sale)
            {
                // Operation false = subtract
                 _repoArticle.UpdateStock(sm.Quantity, sm.ArticleID, false);
            }
            else
            {
                // Purchase and others: Operation true = add
                 _repoArticle.UpdateStock(sm.Quantity, sm.ArticleID, true);
            }

            return _repoStockMovement.AddStockMovement(sm);
        }

        public bool DeleteStockMovement(int id)
        {
             var sm = _repoStockMovement.GetStockMovementById(id);
             if (sm != null)
             {
                 // Revert stock update
                 // If it was Sale (Subtract), now Add (true)
                 // If it was Purchase (Add), now Subtract (false)
                 
                 bool operation = sm.Type == StockMovementType.Sale; 
                 // If Sale, operation=true (Add back)
                 // If Purchase, operation=false (Remove)
                 
                 _repoArticle.UpdateStock(sm.Quantity, sm.ArticleID, operation);
                 
                 return _repoStockMovement.DeleteStockMovement(id);
             }
             return false;
        }

        public StockMovement GetStockMovementById(int id)
        {
            return _repoStockMovement.GetStockMovementById(id);
        }

        public List<StockMovement> GetStockMovements()
        {
            return _repoStockMovement.GetStockMovements();
        }

        public List<dynamic> GetStockMovementsDetails()
        {
            return _repoStockMovement.GetStockMovementsDetails();
        }

        public StockMovement UpdateStockMovement(int id, StockMovement stockMovement)
        {
            stockMovement.idStockMovement = id;
            return _repoStockMovement.UpdateStockMovement(stockMovement);
        }
    }
}
