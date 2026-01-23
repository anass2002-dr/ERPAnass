using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class TenantDtos
    {
        public Guid idTenant { get; set; }
        [DefaultValue(null)]
        public string CompanyName { get; set; }
        [DefaultValue(null)]
        public string Domain { get; set; }
        [DefaultValue(true)]
        public Boolean IsAcitve { get; set; }

        public TenantDtos(Tenant tenant)
        {
            this.idTenant = tenant.idTenant;
            this.CompanyName = tenant.CompanyName;
            this.Domain = tenant.Domain;
            this.IsAcitve = tenant.IsAcitve;
        }

        public TenantDtos() { }
    }
}
