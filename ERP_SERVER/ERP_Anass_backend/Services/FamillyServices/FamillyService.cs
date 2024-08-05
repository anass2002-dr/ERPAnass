using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.FamilyRepo;
using Microsoft.AspNetCore.Http.Metadata;

namespace ERP_Anass_backend.Services.FamillyServices
{
    public class FamillyService : IFamillyService
    {
        private readonly IFamillyRepo _IFamillyRepo;

        public FamillyService(IFamillyRepo repoFamilly)
        {
            _IFamillyRepo = repoFamilly;
        }

        public Familly AddFamilly(FamillyDtos familly)
        {
            Familly fm = new Familly();
            fm.familyRef = familly.familyRef;
            fm.familyDesc = familly.familyDesc;
            fm.familyName = familly.familyName;
            return _IFamillyRepo.AddFamilly(fm);
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

        public Familly UpdateFamilly(FamillyDtos familly)
        {
            Familly fm = new Familly();
            fm.idFamilly = familly.idFamilly;
            fm.familyRef = familly.familyRef;
            fm.familyDesc = familly.familyDesc;
            fm.familyName = familly.familyName;
            return _IFamillyRepo.UpdateFamilly(fm);
        }
    }
}
