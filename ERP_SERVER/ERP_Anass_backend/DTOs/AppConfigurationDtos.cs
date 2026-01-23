using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class AppConfigurationDtos
    {
        public int idAppConfiguration { get; set; }
        [DefaultValue(null)]
        public string Key { get; set; }
        [DefaultValue(null)]
        public string Value { get; set; }
        public Guid TenantId { get; set; }

        public AppConfigurationDtos(AppConfiguration config)
        {
            this.idAppConfiguration = config.idAppConfiguration;
            this.Key = config.Key;
            this.Value = config.Value;
            this.TenantId = config.TenantId;
        }

        public AppConfigurationDtos() { }
    }
}
