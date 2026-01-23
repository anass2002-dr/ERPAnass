using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.TenantRepo;

namespace ERP_Anass_backend.Services.TenantService
{
    public class TenantService : IServiceTenant, ITenantProvider
    {
        private readonly IRepoTenant _repoTenant;
        // Mocking a fixed tenant for dev/testing. 
        // In real app, this would come from HttpContextAccessor
        public Guid CurrentTenantId => Guid.Parse("00000000-0000-0000-0000-000000000001"); 

        public TenantService(IRepoTenant repoTenant)
        {
            _repoTenant = repoTenant;
        }

        public Tenant AddTenant(TenantDtos tenantDtos)
        {
            Tenant tenant = new Tenant();
            tenant.CompanyName = tenantDtos.CompanyName;
            tenant.Domain = tenantDtos.Domain;
            tenant.IsAcitve = tenantDtos.IsAcitve;
            return _repoTenant.AddTenant(tenant);
        }

        public bool DeleteTenant(Guid id)
        {
            return _repoTenant.DeleteTenant(id);
        }

        public Tenant GetTenantById(Guid id)
        {
            return _repoTenant.GetTenantById(id);
        }

        public List<Tenant> GetTenants()
        {
            return _repoTenant.GetTenants();
        }

        public Tenant UpdateTenant(Guid id, Tenant tenant)
        {
            tenant.idTenant = id;
            return _repoTenant.UpdateTenant(tenant);
        }
    }
}
