using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public class ModuleLicense : BaseEntity
    {
        [Key]
        public int idModuleLicense { get; set; }
        public string ModuleName { get; set; }
        public Boolean IsLicensed { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
