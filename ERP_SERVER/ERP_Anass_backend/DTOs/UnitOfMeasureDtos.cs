using ERP_Anass_backend.Models;
using System.ComponentModel;

namespace ERP_Anass_backend.DTOs
{
    public class UnitOfMeasureDtos
    {
        public int idUom { get; set; }
        [DefaultValue(null)]
        public string UomName { get; set; }
        [DefaultValue(null)]
        public string Abbreviation { get; set; }
        public decimal? Multiplier { get; set; }
        public Guid TenantId { get; set; }

        public UnitOfMeasureDtos(UnitOfMeasure uom)
        {
            this.idUom = uom.idUom;
            this.UomName = uom.UomName;
            this.Abbreviation = uom.Abbreviation;
            this.Multiplier = uom.Multiplier;
            this.TenantId = uom.TenantId;
        }

        public UnitOfMeasureDtos() { }
    }
}
