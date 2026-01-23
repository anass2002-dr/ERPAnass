using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.TenantService
{
    public interface IServiceTenant
    {
        Tenant GetTenantById(Guid id);
        List<Tenant> GetTenants();
        Tenant AddTenant(TenantDtos tenant);
        Tenant UpdateTenant(Guid id, Tenant tenant);
        bool DeleteTenant(Guid id);
    }
}
