using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.UnitOfMeasureRepo
{
    public class RepoUnitOfMeasure : IRepoUnitOfMeasure
    {
        private readonly DbContextERP _context;
        private readonly ITenantProvider _tenantProvider;

        public RepoUnitOfMeasure(DbContextERP context, ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }

        public UnitOfMeasure AddUnitOfMeasure(UnitOfMeasure uom)
        {
            uom.TenantId = _tenantProvider.CurrentTenantId;
            var added = _context.Set<UnitOfMeasure>().Add(uom);
            _context.SaveChanges();
            return added.Entity;
        }

        public bool DeleteUnitOfMeasure(int id)
        {
            var uom = _context.Set<UnitOfMeasure>()
                .FirstOrDefault(u => u.idUom == id && u.TenantId == _tenantProvider.CurrentTenantId);
            
            if (uom == null) return false;

            _context.Set<UnitOfMeasure>().Remove(uom);
            _context.SaveChanges();
            return true;
        }

        public UnitOfMeasure GetUnitOfMeasureById(int id)
        {
            return _context.Set<UnitOfMeasure>()
                .FirstOrDefault(u => u.idUom == id && u.TenantId == _tenantProvider.CurrentTenantId);
        }

        public List<UnitOfMeasure> GetUnitOfMeasures()
        {
            return _context.Set<UnitOfMeasure>()
                .Where(u => u.TenantId == _tenantProvider.CurrentTenantId)
                .ToList();
        }

        public UnitOfMeasure UpdateUnitOfMeasure(UnitOfMeasure uom)
        {
            var existing = GetUnitOfMeasureById(uom.idUom);
            if (existing != null)
            {
                existing.UomName = uom.UomName ?? existing.UomName;
                existing.Abbreviation = uom.Abbreviation ?? existing.Abbreviation;
                
                _context.SaveChanges();
                return existing;
            }
            return null;
        }
    }
}
