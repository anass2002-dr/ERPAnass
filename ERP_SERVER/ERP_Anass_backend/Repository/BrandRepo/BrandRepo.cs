using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.BrandRepo
{
    public class BrandRepo : IBrandRepo
    {
        private readonly DbContextERP _context;

        public BrandRepo(DbContextERP context)
        {
            _context = context;
        }

        public Brand AddBrand(Brand brand)
        {
            _context.Brand.Add(brand);
            _context.SaveChanges();
            return brand;
        }

        public bool DeleteBrand(int id)
        {
            var brand = _context.Brand.FirstOrDefault(b => b.BrandID == id);
            if (brand == null)
            {
                return false; // Brand not found
            }
            _context.Brand.Remove(brand);
            _context.SaveChanges();
            return true;
        }

        public Brand GetBrandById(int id)
        {
            return _context.Brand.FirstOrDefault(b => b.BrandID == id);
        }

        public List<Brand> GetBrands()
        {
            return _context.Brand.Include(b => b.Familly).ToList();
        }

        public Brand UpdateBrand(int id, Brand brand)
        {
            var existingBrand = _context.Brand.FirstOrDefault(b => b.BrandID == id);
            if (existingBrand != null)
            {
                existingBrand.BrandName = brand.BrandName;
                existingBrand.BrandRef = brand.BrandRef;
                existingBrand.IsAcitve = brand.IsAcitve;
                existingBrand.idFamilly = brand.idFamilly;

                _context.Brand.Update(existingBrand);
                _context.SaveChanges();
                return existingBrand;
            }
            return null;
        }
    }
}
