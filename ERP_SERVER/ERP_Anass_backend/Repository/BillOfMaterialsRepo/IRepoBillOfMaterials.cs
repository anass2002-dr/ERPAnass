using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.BillOfMaterialsRepo
{
    public interface IRepoBillOfMaterials
    {
        BillOfMaterials GetBOMById(int id);
        List<BillOfMaterials> GetBOMs();
        List<dynamic> GetBOMsDetails();
        BillOfMaterials AddBOM(BillOfMaterials bom);
        BillOfMaterials UpdateBOM(BillOfMaterials bom);
        bool DeleteBOM(int id);
        List<BillOfMaterials> GetBOMsByParentArticle(int parentId);
    }
}
