using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.BillOfMaterialsService
{
    public interface IServiceBillOfMaterials
    {
        BillOfMaterials GetBOMById(int id);
        List<BillOfMaterials> GetBOMs();
        List<dynamic> GetBOMsDetails();
        BillOfMaterials AddBOM(BillOfMaterialsDtos bom);
        BillOfMaterials UpdateBOM(int id, BillOfMaterials bom);
        bool DeleteBOM(int id);
    }
}
