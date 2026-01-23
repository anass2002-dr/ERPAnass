using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public class UnitOfMeasure : BaseEntity
    {
        [Key]
        public int idUom { get; set; }
        public string UomName { get; set; } // Kg, Liters, Pcs
        public string Abbreviation { get; set; }
    }
}
