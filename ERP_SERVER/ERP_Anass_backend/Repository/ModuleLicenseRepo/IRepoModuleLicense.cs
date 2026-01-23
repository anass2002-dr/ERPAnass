using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.ModuleLicenseRepo
{
    public interface IRepoModuleLicense
    {
        ModuleLicense GetModuleLicenseById(int id);
        List<ModuleLicense> GetModuleLicenses();
        ModuleLicense AddModuleLicense(ModuleLicense moduleLicense);
        ModuleLicense UpdateModuleLicense(ModuleLicense moduleLicense);
        bool DeleteModuleLicense(int id);
        bool IsModuleActive(string moduleName);
    }
}
