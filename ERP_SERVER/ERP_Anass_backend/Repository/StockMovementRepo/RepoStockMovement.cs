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
                .Include(s => s.Warehouse)
                .Include(s => s.StockMovementDetails)
                    .ThenInclude(d => d.Article)
                .FirstOrDefault(s => s.idStockMovement == id);
        }

        public List<StockMovement> GetStockMovements()
        {
             return _context.Set<StockMovement>()
                .Include(s => s.Warehouse)
                .Include(s => s.StockMovementDetails)
                    .ThenInclude(d => d.Article)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public List<dynamic> GetStockMovementsDetails()
        {
            // Updated to return Headers with Details summary or Full object
            // User wants list of Movements (Header info mostly)
            return _context.Set<StockMovement>()
                .Include(s => s.Warehouse)
                 .Select(s => new
                 {
                     s.idStockMovement,
                     s.WarehouseID,
                     WarehouseName = s.Warehouse != null ? s.Warehouse.Name : "",
                     s.Type,
                     s.MovementDate,
                     ItemCount = s.StockMovementDetails.Count() // Useful for list view
                 })
                 .ToList<dynamic>();
        }

         public List<StockMovement> GetStockMovementsByArticle(int articleId)
        {
            return _context.Set<StockMovement>()
                .Where(s => s.StockMovementDetails.Any(d => d.ArticleID == articleId))
                .Include(s => s.Warehouse)
                .Include(s => s.StockMovementDetails)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public List<StockMovement> GetStockMovementsByWarehouse(int warehouseId)
        {
            return _context.Set<StockMovement>()
                .Where(s => s.WarehouseID == warehouseId)
                .Include(s => s.StockMovementDetails)
                    .ThenInclude(d => d.Article)
                .OrderByDescending(s => s.MovementDate)
                .ToList();
        }

        public StockMovement UpdateStockMovement(StockMovement stockMovement)
        {
             var existing = _context.Set<StockMovement>()
                 .Include(s => s.StockMovementDetails)
                 .FirstOrDefault(s => s.idStockMovement == stockMovement.idStockMovement);

             if (existing != null)
             {
                 existing.WarehouseID = stockMovement.WarehouseID != 0 ? stockMovement.WarehouseID : existing.WarehouseID;
                 existing.Type = stockMovement.Type; 
                 existing.MovementDate = stockMovement.MovementDate;

                 // Create simple way to update details if provided? 
                 // For now, assume mainly header update or complex logic in Service.
                 // Ideally, we shouldn't wipe details here unless intended.
                 
                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
