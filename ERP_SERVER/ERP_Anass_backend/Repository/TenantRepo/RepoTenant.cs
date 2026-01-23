using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.TenantRepo
{
    public class RepoTenant : IRepoTenant
    {
        private readonly DbContextERP _context;

        public RepoTenant(DbContextERP context)
        {
            _context = context;
        }

        public Tenant AddTenant(Tenant tenant)
        {
            var t = _context.Set<Tenant>().Add(tenant);
            _context.SaveChanges();
            return t.Entity;
        }

        public bool DeleteTenant(Guid id)
        {
            var tenant = _context.Set<Tenant>().Find(id);
            if (tenant == null) return false;

            _context.Set<Tenant>().Remove(tenant);
            _context.SaveChanges();
            return true;
        }

        public Tenant GetTenantById(Guid id)
        {
            return _context.Set<Tenant>().Find(id);
        }

        public List<Tenant> GetTenants()
        {
            return _context.Set<Tenant>().ToList();
        }

        public Tenant UpdateTenant(Tenant tenant)
        {
            var existing = _context.Set<Tenant>().Find(tenant.idTenant);
            if (existing != null)
            {
                existing.CompanyName = tenant.CompanyName ?? existing.CompanyName;
                existing.Domain = tenant.Domain ?? existing.Domain;
                existing.IsAcitve = tenant.IsAcitve;
                
                _context.SaveChanges();
                return existing;
            }
            return null;
        }
    }
}
