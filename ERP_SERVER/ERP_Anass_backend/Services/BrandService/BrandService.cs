using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.BrandRepo;

namespace ERP_Anass_backend.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepo _brandRepo;

        public BrandService(IBrandRepo brandRepo)
        {
            _brandRepo = brandRepo;
        }

        public Brand AddBrand(Brand brand)
        {
            return _brandRepo.AddBrand(brand);
        }

        public bool DeleteBrand(int id)
        {
            return _brandRepo.DeleteBrand(id);
        }

        public Brand GetBrandById(int id)
        {
            return _brandRepo.GetBrandById(id);
        }

        public List<Brand> GetBrands()
        {
            return _brandRepo.GetBrands();
        }

        public Brand UpdateBrand(int id, Brand brand)
        {
            return _brandRepo.UpdateBrand(id, brand);
        }
    }
}
