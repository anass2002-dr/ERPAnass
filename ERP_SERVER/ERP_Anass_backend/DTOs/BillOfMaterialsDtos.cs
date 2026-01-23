using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class BillOfMaterialsDtos
    {
        public int idBOM { get; set; }
        [DefaultValue(0)]
        public int ParentArticleId { get; set; }
        [DefaultValue(0)]
        public int ChildArticleId { get; set; }
        [DefaultValue(0)]
        public float QuantityNeeded { get; set; }
        public Guid TenantId { get; set; }

        public BillOfMaterialsDtos(BillOfMaterials bom)
        {
            this.idBOM = bom.idBOM;
            this.ParentArticleId = bom.ParentArticleId;
            this.ChildArticleId = bom.ChildArticleId;
            this.QuantityNeeded = bom.QuantityNeeded;
            this.TenantId = bom.TenantId;
        }

        public BillOfMaterialsDtos() { }
    }
}
