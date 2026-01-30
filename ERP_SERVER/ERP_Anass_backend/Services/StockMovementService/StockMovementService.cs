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
        private readonly ERP_Anass_backend.Repository.PurchaseRepo.IPurchaseRepo _purchaseRepo;

        public StockMovementService(IRepoStockMovement repoStockMovement, IRepoArticle repoArticle, ERP_Anass_backend.Repository.PurchaseRepo.IPurchaseRepo purchaseRepo)
        {
            _repoStockMovement = repoStockMovement;
            _repoArticle = repoArticle;
            _purchaseRepo = purchaseRepo;
        }

        public StockMovement AddStockMovement(StockMovementDtos stockMovementDtos)
        {
            StockMovement sm = new StockMovement();
            sm.WarehouseID = stockMovementDtos.WarehouseID;
            sm.Type = stockMovementDtos.Type;
            sm.MovementDate = DateTime.UtcNow;
            
            sm.StockMovementDetails = new List<StockMovementDetails>();

            foreach (var detailDto in stockMovementDtos.StockMovementDetails)
            {
                 var detail = new StockMovementDetails
                 {
                     ArticleID = detailDto.ArticleID,
                     Quantity = detailDto.Quantity
                 };
                 sm.StockMovementDetails.Add(detail);

                 // Update Stock Logic
                 if (sm.Type == StockMovementType.Sale)
                 {
                      _repoArticle.UpdateStock(detail.Quantity, detail.ArticleID, false);
                 }
                 else
                 {
                      _repoArticle.UpdateStock(detail.Quantity, detail.ArticleID, true);
                 }
            }

            return _repoStockMovement.AddStockMovement(sm);
        }

        // ... Delete logic needs refactor too but sticking to request scope first ...
        // Re-implementing Delete to be safe (reverting stock) requires fetching details
        
        public bool DeleteStockMovement(int id)
        {
             var sm = _repoStockMovement.GetStockMovementById(id);
             if (sm != null && sm.StockMovementDetails != null)
             {
                 foreach(var detail in sm.StockMovementDetails)
                 {
                     bool operation = sm.Type == StockMovementType.Sale; 
                     // Revert: Sale(Sub) -> Add(true), Purchase(Add) -> Sub(false)
                     _repoArticle.UpdateStock(detail.Quantity, detail.ArticleID, operation);
                 }
                 
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

        public async Task<bool> ReceivePurchaseItems(int purchaseId, int warehouseId)
        {
            var purchase = _purchaseRepo.GetPurchaseById(purchaseId);
            if (purchase == null) throw new KeyNotFoundException("Purchase not found");

            if (purchase.PurchaseDetails == null || !purchase.PurchaseDetails.Any())
                return false;

            var smDto = new StockMovementDtos
            {
                WarehouseID = warehouseId,
                Type = StockMovementType.Purchase,
                MovementDate = DateTime.UtcNow
            };

            foreach (var item in purchase.PurchaseDetails)
            {
                smDto.StockMovementDetails.Add(new StockMovementDetailDto
                {
                    ArticleID = item.idArticle ?? 0,
                    Quantity = (int)(item.Quantity ?? 0)
                });
            }

            // Single call creates Header + N Details + Updates Stock N times
            AddStockMovement(smDto);
            return true;
        }
    }
}
