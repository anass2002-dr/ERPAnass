using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.FamilyRepo;

namespace ERP_Anass_backend.Services.FamillyServices
{
    public class FamillyService : IFamillyService
    {
        private readonly IFamillyRepo _IFamillyRepo;

        public FamillyService(IFamillyRepo repoFamilly)
        {
            _IFamillyRepo = repoFamilly;
        }

        public Familly AddFamilly(Familly familly)
        {
            
            return _IFamillyRepo.AddFamilly(familly);
        }

        

        public bool DeleteFamilly(int id)
        {
            return _IFamillyRepo.DeleteFamilly(id);
        }

        public Familly GetFamilyById(int id)
        {
            return _IFamillyRepo.GetFamilyById(id);
        }

    

        public List<Familly> GetFamillys()
        {
            return _IFamillyRepo.GetFamillys();
        }

        public Familly UpdateFamilly(Familly familly)
        {
            return _IFamillyRepo.UpdateFamilly(familly);
        }
    }
}
