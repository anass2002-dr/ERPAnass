using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class ModuleLicenseDtos
    {
        public int idModuleLicense { get; set; }
        [DefaultValue(null)]
        public string ModuleName { get; set; }
        [DefaultValue(false)]
        public Boolean IsLicensed { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid TenantId { get; set; }

        public ModuleLicenseDtos(ModuleLicense license)
        {
            this.idModuleLicense = license.idModuleLicense;
            this.ModuleName = license.ModuleName;
            this.IsLicensed = license.IsLicensed;
            this.ExpiryDate = license.ExpiryDate;
            this.TenantId = license.TenantId;
        }

        public ModuleLicenseDtos() { }
    }
}
