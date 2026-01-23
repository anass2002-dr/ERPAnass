using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.WarehouseService
{
    public interface IServiceWarehouse
    {
        Warehouse GetWarehouseById(int id);
        List<Warehouse> GetWarehouses();
        List<dynamic> GetWarehousesDetails();
        Warehouse AddWarehouse(WarehouseDtos warehouse);
        Warehouse UpdateWarehouse(int id, Warehouse warehouse);
        bool DeleteWarehouse(int id);
    }
}
