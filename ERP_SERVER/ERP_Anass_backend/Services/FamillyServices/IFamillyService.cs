using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.FamillyServices
{
    public interface IFamillyService
    {
        Familly GetFamilyById(int id);
        List<Familly> GetFamillys();
        Familly AddFamilly(Familly familly);
        Familly UpdateFamilly(Familly familly);
        Boolean DeleteFamilly(int id);
    }
}
