using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.TenantRepo
{
    public interface IRepoTenant
    {
        Tenant GetTenantById(Guid id);
        List<Tenant> GetTenants();
        Tenant AddTenant(Tenant tenant);
        Tenant UpdateTenant(Tenant tenant);
        bool DeleteTenant(Guid id);
    }
}
