using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.ModuleLicenseService
{
    public interface IServiceModuleLicense
    {
        ModuleLicense GetModuleLicenseById(int id);
        List<ModuleLicense> GetModuleLicenses();
        ModuleLicense AddModuleLicense(ModuleLicenseDtos moduleLicense);
        ModuleLicense UpdateModuleLicense(int id, ModuleLicense moduleLicense);
        bool DeleteModuleLicense(int id);
        bool IsModuleActive(string moduleName);
    }
}
