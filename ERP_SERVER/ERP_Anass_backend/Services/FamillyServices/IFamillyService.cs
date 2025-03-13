using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.FamillyServices
{
    public interface IFamillyService
    {
        Familly GetFamilyById(int id);
        List<Familly> GetFamillys();
        Familly AddFamilly(FamillyDtos familly);
        Familly UpdateFamilly(FamillyDtos familly);
        Boolean DeleteFamilly(int id);

        //Familly GetFamilyById(int id);
        //List<Familly> GetFamillys();
        //Familly AddFamilly(FamillyDtos familly);
        //Familly UpdateFamilly(FamillyDtos familly);
        //Boolean DeleteFamilly(int id);


    }
}
