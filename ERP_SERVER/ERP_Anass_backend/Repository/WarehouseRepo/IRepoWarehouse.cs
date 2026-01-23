using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.WarehouseRepo
{
    public interface IRepoWarehouse
    {
        Warehouse GetWarehouseById(int id);
        List<dynamic> GetWarehousesDetails();
        List<Warehouse> GetWarehouses();
        Warehouse AddWarehouse(Warehouse warehouse);
        Warehouse UpdateWarehouse(Warehouse warehouse);
        Boolean DeleteWarehouse(int id);
    }
}
