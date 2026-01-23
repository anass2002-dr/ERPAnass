using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class WarehouseDtos
    {
        public int idWarehouse { get; set; }
        [DefaultValue(null)]
        public string Name { get; set; }
        [DefaultValue(null)]
        public string Location { get; set; }
        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }

        public WarehouseDtos(Warehouse warehouse)
        {
            this.idWarehouse = warehouse.idWarehouse;
            this.Name = warehouse.Name;
            this.Location = warehouse.Location;
            this.IsAcitve = warehouse.IsAcitve;
        }

        public WarehouseDtos() { }
    }
}
