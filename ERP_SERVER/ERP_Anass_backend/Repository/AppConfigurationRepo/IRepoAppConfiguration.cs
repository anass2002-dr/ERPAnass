using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.AppConfigurationRepo
{
    public interface IRepoAppConfiguration
    {
        AppConfiguration GetAppConfigurationById(int id);
        List<AppConfiguration> GetAppConfigurations();
        AppConfiguration AddAppConfiguration(AppConfiguration appConfig);
        AppConfiguration UpdateAppConfiguration(AppConfiguration appConfig);
        bool DeleteAppConfiguration(int id);
        string GetConfigurationValue(string key);
    }
}
