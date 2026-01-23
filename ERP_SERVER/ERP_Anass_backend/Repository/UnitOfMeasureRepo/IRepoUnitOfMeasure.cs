using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.UnitOfMeasureRepo
{
    public interface IRepoUnitOfMeasure
    {
        UnitOfMeasure GetUnitOfMeasureById(int id);
        List<UnitOfMeasure> GetUnitOfMeasures();
        UnitOfMeasure AddUnitOfMeasure(UnitOfMeasure uom);
        UnitOfMeasure UpdateUnitOfMeasure(UnitOfMeasure uom);
        bool DeleteUnitOfMeasure(int id);
    }
}
