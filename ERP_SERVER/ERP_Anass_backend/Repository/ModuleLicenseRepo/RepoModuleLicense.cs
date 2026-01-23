using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.ModuleLicenseRepo
{
    public class RepoModuleLicense : IRepoModuleLicense
    {
        private readonly DbContextERP _context;
        private readonly ITenantProvider _tenantProvider;

        public RepoModuleLicense(DbContextERP context, ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }

        public ModuleLicense AddModuleLicense(ModuleLicense moduleLicense)
        {
            moduleLicense.TenantId = _tenantProvider.CurrentTenantId;
            var ml = _context.Set<ModuleLicense>().Add(moduleLicense);
            _context.SaveChanges();
            return ml.Entity;
        }

        public bool DeleteModuleLicense(int id)
        {
            // Only allow deleting self-tenant data
            var moduleLicense = _context.Set<ModuleLicense>()
                .FirstOrDefault(m => m.idModuleLicense == id && m.TenantId == _tenantProvider.CurrentTenantId);
            
            if (moduleLicense == null) return false;

            _context.Set<ModuleLicense>().Remove(moduleLicense);
            _context.SaveChanges();
            return true;
        }

        public ModuleLicense GetModuleLicenseById(int id)
        {
             return _context.Set<ModuleLicense>()
                .FirstOrDefault(m => m.idModuleLicense == id && m.TenantId == _tenantProvider.CurrentTenantId);
        }

        public List<ModuleLicense> GetModuleLicenses()
        {
             return _context.Set<ModuleLicense>()
                .Where(m => m.TenantId == _tenantProvider.CurrentTenantId)
                .ToList();
        }

        public bool IsModuleActive(string moduleName)
        {
            return _context.Set<ModuleLicense>()
                .Any(m => m.TenantId == _tenantProvider.CurrentTenantId 
                       && m.ModuleName == moduleName 
                       && m.IsLicensed 
                       && m.ExpiryDate > DateTime.UtcNow);
        }

        public ModuleLicense UpdateModuleLicense(ModuleLicense moduleLicense)
        {
             var existing = GetModuleLicenseById(moduleLicense.idModuleLicense);
             if (existing != null)
             {
                 existing.ModuleName = moduleLicense.ModuleName ?? existing.ModuleName;
                 existing.IsLicensed = moduleLicense.IsLicensed;
                 existing.ExpiryDate = moduleLicense.ExpiryDate;
                 // TenantId usually shouldn't change
                 // existing.TenantId = moduleLicense.TenantId; 

                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
