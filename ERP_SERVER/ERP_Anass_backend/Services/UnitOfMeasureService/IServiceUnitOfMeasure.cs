using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.UnitOfMeasureService
{
    public interface IServiceUnitOfMeasure
    {
        UnitOfMeasure GetUnitOfMeasureById(int id);
        List<UnitOfMeasure> GetUnitOfMeasures();
        UnitOfMeasure AddUnitOfMeasure(UnitOfMeasureDtos uom);
        UnitOfMeasure UpdateUnitOfMeasure(int id, UnitOfMeasure uom);
        bool DeleteUnitOfMeasure(int id);
    }
}
