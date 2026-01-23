using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.AppConfigurationService
{
    public interface IServiceAppConfiguration
    {
        AppConfiguration GetAppConfigurationById(int id);
        List<AppConfiguration> GetAppConfigurations();
        AppConfiguration AddAppConfiguration(AppConfigurationDtos appConfig);
        AppConfiguration UpdateAppConfiguration(int id, AppConfiguration appConfig);
        bool DeleteAppConfiguration(int id);
        string GetConfigurationValue(string key);
    }
}
