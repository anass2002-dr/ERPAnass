using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.ModuleLicenseRepo;

namespace ERP_Anass_backend.Services.ModuleLicenseService
{
    public class ModuleLicenseService : IServiceModuleLicense
    {
        private readonly IRepoModuleLicense _repoModuleLicense;

        public ModuleLicenseService(IRepoModuleLicense repoModuleLicense)
        {
            _repoModuleLicense = repoModuleLicense;
        }

        public ModuleLicense AddModuleLicense(ModuleLicenseDtos moduleLicenseDtos)
        {
            ModuleLicense ml = new ModuleLicense();
            ml.ModuleName = moduleLicenseDtos.ModuleName;
            ml.IsLicensed = moduleLicenseDtos.IsLicensed;
            ml.ExpiryDate = moduleLicenseDtos.ExpiryDate;
            // TenantId handled by Repo or set here if needed, but Repo sets it from Provider usually
            // but let's assume DTO might carry it if superadmin is creating it. 
            // In strict SaaS, tenant creates data for THEMSELVES, so provider is truth.
            // If SuperAdmin creates license for Tenant, we need a way to override.
            // For now, assuming Repo uses CurrentTenantId context which might be the Tenant itself?
            // Actually, Licenses are usually assigned BY ADMIN. 
            // BUT requirements say: "Repositories include a filter ... where TenantId == CurrentTenantId".
            // If this is the TENANT'S view, they can see their licenses.
            // If ADMIN creation, they would use a different Repo or override.
            // Sticking to "Data Isolation" request -> Repo forces TenantId.
            
            return _repoModuleLicense.AddModuleLicense(ml);
        }

        public bool DeleteModuleLicense(int id)
        {
            return _repoModuleLicense.DeleteModuleLicense(id);
        }

        public ModuleLicense GetModuleLicenseById(int id)
        {
            return _repoModuleLicense.GetModuleLicenseById(id);
        }

        public List<ModuleLicense> GetModuleLicenses()
        {
            return _repoModuleLicense.GetModuleLicenses();
        }

        public bool IsModuleActive(string moduleName)
        {
            return _repoModuleLicense.IsModuleActive(moduleName);
        }

        public ModuleLicense UpdateModuleLicense(int id, ModuleLicense moduleLicense)
        {
            moduleLicense.idModuleLicense = id;
            return _repoModuleLicense.UpdateModuleLicense(moduleLicense);
        }
    }
}
