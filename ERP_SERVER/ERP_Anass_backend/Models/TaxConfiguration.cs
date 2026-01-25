using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public class TaxConfiguration : BaseEntity
    {
        [Key]
        public int idTaxConfig { get; set; }
        public string TaxName { get; set; } // e.g., "VAT 20%", "KDV 18%"
        public decimal TaxRate { get; set; } // e.g., 20.0, 18.0
        public string? Description { get; set; }
    }
}
