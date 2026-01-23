using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.BrandRepo
{
    public interface IBrandRepo
    {
        List<Brand> GetBrands();
        Brand GetBrandById(int id);
        Brand AddBrand(Brand brand);
        Brand UpdateBrand(int id, Brand brand);
        bool DeleteBrand(int id);
    }
}
