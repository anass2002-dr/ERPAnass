using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.AppConfigurationRepo;

namespace ERP_Anass_backend.Services.AppConfigurationService
{
    public class AppConfigurationService : IServiceAppConfiguration
    {
        private readonly IRepoAppConfiguration _repoAppConfiguration;

        public AppConfigurationService(IRepoAppConfiguration repoAppConfiguration)
        {
            _repoAppConfiguration = repoAppConfiguration;
        }

        public AppConfiguration AddAppConfiguration(AppConfigurationDtos appConfigDtos)
        {
            AppConfiguration ac = new AppConfiguration();
            ac.Key = appConfigDtos.Key;
            ac.Value = appConfigDtos.Value;
            
            return _repoAppConfiguration.AddAppConfiguration(ac);
        }

        public bool DeleteAppConfiguration(int id)
        {
            return _repoAppConfiguration.DeleteAppConfiguration(id);
        }

        public AppConfiguration GetAppConfigurationById(int id)
        {
            return _repoAppConfiguration.GetAppConfigurationById(id);
        }

        public List<AppConfiguration> GetAppConfigurations()
        {
            return _repoAppConfiguration.GetAppConfigurations();
        }

        public string GetConfigurationValue(string key)
        {
            return _repoAppConfiguration.GetConfigurationValue(key);
        }

        public AppConfiguration UpdateAppConfiguration(int id, AppConfiguration appConfig)
        {
            appConfig.idAppConfiguration = id;
            return _repoAppConfiguration.UpdateAppConfiguration(appConfig);
        }
    }
}
