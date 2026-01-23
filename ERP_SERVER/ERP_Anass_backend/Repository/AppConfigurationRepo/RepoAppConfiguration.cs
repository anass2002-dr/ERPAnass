using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.AppConfigurationRepo
{
    public class RepoAppConfiguration : IRepoAppConfiguration
    {
        private readonly DbContextERP _context;
        private readonly ITenantProvider _tenantProvider;

        public RepoAppConfiguration(DbContextERP context, ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }

        public AppConfiguration AddAppConfiguration(AppConfiguration appConfig)
        {
            appConfig.TenantId = _tenantProvider.CurrentTenantId;
            var ac = _context.Set<AppConfiguration>().Add(appConfig);
            _context.SaveChanges();
            return ac.Entity;
        }

        public bool DeleteAppConfiguration(int id)
        {
            var appConfig = _context.Set<AppConfiguration>()
                .FirstOrDefault(a => a.idAppConfiguration == id && a.TenantId == _tenantProvider.CurrentTenantId);
            
            if (appConfig == null) return false;

            _context.Set<AppConfiguration>().Remove(appConfig);
            _context.SaveChanges();
            return true;
        }

        public AppConfiguration GetAppConfigurationById(int id)
        {
             return _context.Set<AppConfiguration>()
                .FirstOrDefault(a => a.idAppConfiguration == id && a.TenantId == _tenantProvider.CurrentTenantId);
        }

        public List<AppConfiguration> GetAppConfigurations()
        {
             return _context.Set<AppConfiguration>()
                .Where(a => a.TenantId == _tenantProvider.CurrentTenantId)
                .ToList();
        }

        public string GetConfigurationValue(string key)
        {
             var config = _context.Set<AppConfiguration>()
                .FirstOrDefault(a => a.TenantId == _tenantProvider.CurrentTenantId && a.Key == key);
             return config?.Value;
        }

        public AppConfiguration UpdateAppConfiguration(AppConfiguration appConfig)
        {
             var existing = GetAppConfigurationById(appConfig.idAppConfiguration);
             if (existing != null)
             {
                 existing.Key = appConfig.Key ?? existing.Key;
                 existing.Value = appConfig.Value ?? existing.Value;
                 // TenantId preserved

                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
