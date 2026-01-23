using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ERP_Anass_backend.Models
{
    public class Warehouse
    {
        [Key]
        public int idWarehouse { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Boolean IsAcitve { get; set; }

        [JsonIgnore]
        public ICollection<StockMovement> StockMovements { get; set; } = [];
    }
}
