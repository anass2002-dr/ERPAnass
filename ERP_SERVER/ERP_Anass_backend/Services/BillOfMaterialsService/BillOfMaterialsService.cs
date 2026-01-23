using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.BillOfMaterialsRepo;

namespace ERP_Anass_backend.Services.BillOfMaterialsService
{
    public class BillOfMaterialsService : IServiceBillOfMaterials
    {
        private readonly IRepoBillOfMaterials _repoBOM;

        public BillOfMaterialsService(IRepoBillOfMaterials repoBOM)
        {
            _repoBOM = repoBOM;
        }

        public BillOfMaterials AddBOM(BillOfMaterialsDtos bomDtos)
        {
             BillOfMaterials bom = new BillOfMaterials();
             bom.ParentArticleId = bomDtos.ParentArticleId;
             bom.ChildArticleId = bomDtos.ChildArticleId;
             bom.QuantityNeeded = bomDtos.QuantityNeeded;
             
             return _repoBOM.AddBOM(bom);
        }

        public bool DeleteBOM(int id)
        {
             return _repoBOM.DeleteBOM(id);
        }

        public BillOfMaterials GetBOMById(int id)
        {
             return _repoBOM.GetBOMById(id);
        }

        public List<BillOfMaterials> GetBOMs()
        {
             return _repoBOM.GetBOMs();
        }

        public List<dynamic> GetBOMsDetails()
        {
             return _repoBOM.GetBOMsDetails();
        }

        public BillOfMaterials UpdateBOM(int id, BillOfMaterials bom)
        {
             bom.idBOM = id;
             return _repoBOM.UpdateBOM(bom);
        }
    }
}
