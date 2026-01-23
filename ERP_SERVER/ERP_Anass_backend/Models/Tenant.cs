using System.ComponentModel.DataAnnotations;

namespace ERP_Anass_backend.Models
{
    public class Tenant
    {
        [Key]
        public Guid idTenant { get; set; }
        public string CompanyName { get; set; }
        public string Domain { get; set; }
        public Boolean IsAcitve { get; set; } = true;
    }
}
