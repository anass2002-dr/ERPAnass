using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.WarehouseRepo;

namespace ERP_Anass_backend.Services.WarehouseService
{
    public class WarehouseService : IServiceWarehouse
    {
        private readonly IRepoWarehouse _repoWarehouse;

        public WarehouseService(IRepoWarehouse repoWarehouse)
        {
            _repoWarehouse = repoWarehouse;
        }

        public Warehouse AddWarehouse(WarehouseDtos warehouse)
        {
            Warehouse wh = new Warehouse();
            wh.Name = warehouse.Name;
            wh.Location = warehouse.Location;
            wh.IsAcitve = warehouse.IsAcitve;
            return _repoWarehouse.AddWarehouse(wh);
        }

        public bool DeleteWarehouse(int id)
        {
            return _repoWarehouse.DeleteWarehouse(id);
        }

        public Warehouse GetWarehouseById(int id)
        {
            return _repoWarehouse.GetWarehouseById(id);
        }

        public List<Warehouse> GetWarehouses()
        {
            return _repoWarehouse.GetWarehouses();
        }

        public List<dynamic> GetWarehousesDetails()
        {
            return _repoWarehouse.GetWarehousesDetails();
        }

        public Warehouse UpdateWarehouse(int id, Warehouse warehouse)
        {
            warehouse.idWarehouse = id;
            return _repoWarehouse.UpdateWarehouse(warehouse);
        }
    }
}
