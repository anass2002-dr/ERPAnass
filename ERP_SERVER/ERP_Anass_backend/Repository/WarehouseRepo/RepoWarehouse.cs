using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.WarehouseRepo
{
    public class RepoWarehouse : IRepoWarehouse
    {
        private readonly DbContextERP _context;

        public RepoWarehouse(DbContextERP context)
        {
            _context = context;
        }

        public Warehouse AddWarehouse(Warehouse warehouse)
        {
            var wh = _context.Set<Warehouse>().Add(warehouse);
            _context.SaveChanges();
            return wh.Entity;
        }

        public bool DeleteWarehouse(int id)
        {
            var warehouse = _context.Set<Warehouse>().Find(id);
            if (warehouse == null)
            {
                return false;
            }

            _context.Set<Warehouse>().Remove(warehouse);
            _context.SaveChanges();
            return true;
        }

        public Warehouse GetWarehouseById(int id)
        {
            return _context.Set<Warehouse>().Find(id);
        }

        public List<Warehouse> GetWarehouses()
        {
            return _context.Set<Warehouse>().Include(w => w.StockMovements).ToList();
        }

        public List<dynamic> GetWarehousesDetails()
        {
             var warehouses = _context.Set<Warehouse>()
                .Select(w => new
                {
                    w.idWarehouse,
                    w.Name,
                    w.Location,
                    w.IsAcitve
                })
                .ToList<dynamic>();
            return warehouses;
        }

        public Warehouse UpdateWarehouse(Warehouse warehouse)
        {
            var existingWarehouse = _context.Set<Warehouse>().Find(warehouse.idWarehouse);
            if (existingWarehouse != null)
            {
                existingWarehouse.Name = warehouse.Name ?? existingWarehouse.Name;
                existingWarehouse.Location = warehouse.Location ?? existingWarehouse.Location;
                existingWarehouse.IsAcitve = warehouse.IsAcitve;
                
                _context.SaveChanges();
                return existingWarehouse;
            }
            return null;
        }
    }
}
