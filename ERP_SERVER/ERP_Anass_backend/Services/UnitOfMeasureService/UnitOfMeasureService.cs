using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.UnitOfMeasureRepo;

namespace ERP_Anass_backend.Services.UnitOfMeasureService
{
    public class UnitOfMeasureService : IServiceUnitOfMeasure
    {
        private readonly IRepoUnitOfMeasure _repoUom;

        public UnitOfMeasureService(IRepoUnitOfMeasure repoUom)
        {
            _repoUom = repoUom;
        }

        public UnitOfMeasure AddUnitOfMeasure(UnitOfMeasureDtos uomDtos)
        {
            var uom = new UnitOfMeasure()
            {
                UomName = uomDtos.UomName,
                Abbreviation = uomDtos.Abbreviation,
                Multiplier = uomDtos.Multiplier, // Added Multiplier mapping
                TenantId = uomDtos.TenantId, // Assuming TenantId comes from DTO
                CreatedAt = DateTime.UtcNow,
                IsAcitve = true
            };
            
            return _repoUom.AddUnitOfMeasure(uom);
        }

        public bool DeleteUnitOfMeasure(int id)
        {
            return _repoUom.DeleteUnitOfMeasure(id);
        }

        public UnitOfMeasure GetUnitOfMeasureById(int id)
        {
            return _repoUom.GetUnitOfMeasureById(id);
        }

        public List<UnitOfMeasure> GetUnitOfMeasures()
        {
            return _repoUom.GetUnitOfMeasures();
        }

        public UnitOfMeasure UpdateUnitOfMeasure(int id, UnitOfMeasure uom)
        {
            uom.idUom = id;
            return _repoUom.UpdateUnitOfMeasure(uom);
        }
    }
}
