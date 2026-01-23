using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.StockMovementRepo
{
    public class RepoStockMovement : IRepoStockMovement
    {
        private readonly DbContextERP _context;

        public RepoStockMovement(DbContextERP context)
        {
            _context = context;
        }

        public StockMovement AddStockMovement(StockMovement stockMovement)
        {
             var sm = _context.Set<StockMovement>().Add(stockMovement);
             _context.SaveChanges();
             return sm.Entity;
        }

        public bool DeleteStockMovement(int id)
        {
             var sm = _context.Set<StockMovement>().Find(id);
             if (sm == null) return false;
             
             _context.Set<StockMovement>().Remove(sm);
             _context.SaveChanges();
             return true;
        }

        public StockMovement GetStockMovementById(int id)
        {
            return _context.Set<StockMovement>()
                .Include(s => s.Article)
                .Include(s => s.Warehouse)
                .FirstOrDefault(s => s.idStockMovement == id);
        }

        public List<StockMovement> GetStockMovements()
        {
             return _context.Set<StockMovement>()
                .Include(s => s.Article)
                .Include(s => s.Warehouse)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public List<dynamic> GetStockMovementsDetails()
        {
            return _context.Set<StockMovement>()
                .Include(s => s.Article)
                .Include(s => s.Warehouse)
                 .Select(s => new
                 {
                     s.idStockMovement,
                     s.ArticleID,
                     ArticleName = s.Article != null ? s.Article.ArticleName : "",
                     s.WarehouseID,
                     WarehouseName = s.Warehouse != null ? s.Warehouse.Name : "",
                     s.Quantity,
                     s.Type,
                     s.MovementDate
                 })
                 .ToList<dynamic>();
        }

         public List<StockMovement> GetStockMovementsByArticle(int articleId)
        {
            return _context.Set<StockMovement>()
                .Where(s => s.ArticleID == articleId)
                .Include(s => s.Warehouse)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public List<StockMovement> GetStockMovementsByWarehouse(int warehouseId)
        {
            return _context.Set<StockMovement>()
                .Where(s => s.WarehouseID == warehouseId)
                .Include(s => s.Article)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public StockMovement UpdateStockMovement(StockMovement stockMovement)
        {
             var existing = _context.Set<StockMovement>().Find(stockMovement.idStockMovement);
             if (existing != null)
             {
                 existing.ArticleID = stockMovement.ArticleID != 0 ? stockMovement.ArticleID : existing.ArticleID;
                 existing.WarehouseID = stockMovement.WarehouseID != 0 ? stockMovement.WarehouseID : existing.WarehouseID;
                 existing.Quantity = stockMovement.Quantity != 0 ? stockMovement.Quantity : existing.Quantity;
                 existing.Type = stockMovement.Type; 
                 // existing.MovementDate = stockMovement.MovementDate; // Keep original date or update? Usually strict, but let's allow it if needed or just skip. User didn't specify. I'll include it.
                 existing.MovementDate = stockMovement.MovementDate;

                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
