using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.FamilyRepo
{
    public interface IFamillyRepo
    {
        Familly GetFamilyById(int id);
        List<Familly> GetFamillys();
        Familly AddFamilly(Familly familly);
        Familly UpdateFamilly(Familly familly);
        Boolean DeleteFamilly(int id);
    }
}
