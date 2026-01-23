using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.BillOfMaterialsRepo
{
    public class RepoBillOfMaterials : IRepoBillOfMaterials
    {
        private readonly DbContextERP _context;
        private readonly ITenantProvider _tenantProvider;

        public RepoBillOfMaterials(DbContextERP context, ITenantProvider tenantProvider)
        {
            _context = context;
            _tenantProvider = tenantProvider;
        }

        public BillOfMaterials AddBOM(BillOfMaterials bom)
        {
            bom.TenantId = _tenantProvider.CurrentTenantId;
            var added = _context.Set<BillOfMaterials>().Add(bom);
            _context.SaveChanges();
            return added.Entity;
        }

        public bool DeleteBOM(int id)
        {
            var bom = _context.Set<BillOfMaterials>()
                .FirstOrDefault(b => b.idBOM == id && b.TenantId == _tenantProvider.CurrentTenantId);
            
            if (bom == null) return false;

            _context.Set<BillOfMaterials>().Remove(bom);
            _context.SaveChanges();
            return true;
        }

        public BillOfMaterials GetBOMById(int id)
        {
             return _context.Set<BillOfMaterials>()
                .Include(b => b.ParentArticle)
                .Include(b => b.ChildArticle)
                .FirstOrDefault(b => b.idBOM == id && b.TenantId == _tenantProvider.CurrentTenantId);
        }

        public List<BillOfMaterials> GetBOMs()
        {
             return _context.Set<BillOfMaterials>()
                .Where(b => b.TenantId == _tenantProvider.CurrentTenantId)
                .Include(b => b.ParentArticle)
                .Include(b => b.ChildArticle)
                .ToList();
        }

        public List<BillOfMaterials> GetBOMsByParentArticle(int parentId)
        {
             return _context.Set<BillOfMaterials>()
                .Where(b => b.TenantId == _tenantProvider.CurrentTenantId && b.ParentArticleId == parentId)
                .Include(b => b.ChildArticle)
                .ToList();
        }

        public List<dynamic> GetBOMsDetails()
        {
             return _context.Set<BillOfMaterials>()
                .Where(b => b.TenantId == _tenantProvider.CurrentTenantId)
                .Include(b => b.ParentArticle)
                .Include(b => b.ChildArticle)
                .Select(b => new
                {
                    b.idBOM,
                    b.ParentArticleId,
                    ParentArticleName = b.ParentArticle != null ? b.ParentArticle.ArticleName : "",
                    b.ChildArticleId,
                    ChildArticleName = b.ChildArticle != null ? b.ChildArticle.ArticleName : "",
                    b.QuantityNeeded
                })
                .ToList<dynamic>();
        }

        public BillOfMaterials UpdateBOM(BillOfMaterials bom)
        {
             var existing = GetBOMById(bom.idBOM);
             if (existing != null)
             {
                 existing.ParentArticleId = bom.ParentArticleId != 0 ? bom.ParentArticleId : existing.ParentArticleId;
                 existing.ChildArticleId = bom.ChildArticleId != 0 ? bom.ChildArticleId : existing.ChildArticleId;
                 existing.QuantityNeeded = bom.QuantityNeeded != 0 ? bom.QuantityNeeded : existing.QuantityNeeded;

                 _context.SaveChanges();
                 return existing;
             }
             return null;
        }
    }
}
