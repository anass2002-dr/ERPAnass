using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.SupplierRepo
{
    public class SupplierRepo: ISupplierRepo
    {
        private readonly DbContextERP _context;

        public SupplierRepo(DbContextERP context)
        {
            _context = context;
        }

        public List<Supplier> GetSuppliers()
        {
            return _context.Supplier.Where(s=>s.IsAcitve==true).ToList();
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Supplier.Include(s => s.Country)
                .FirstOrDefault(s => s.idSupplier == id);
        }

        public Supplier AddSupplier(Supplier supplier)
        {
            _context.Supplier.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public Supplier UpdateSupplier(int id, Supplier Supplier)
        {
            var existingSupplier = _context.Supplier.FirstOrDefault(s => s.idSupplier == id);
            if (existingSupplier != null)
            {
                existingSupplier.SupplierRef = Supplier.SupplierRef;
                existingSupplier.SupplierName = Supplier.SupplierName;
                existingSupplier.ContactPerson = Supplier.ContactPerson;
                existingSupplier.Phone = Supplier.Phone;
                existingSupplier.Email = Supplier.Email;
                existingSupplier.Address = Supplier.Address;
                existingSupplier.CountryId = Supplier.CountryId;
                existingSupplier.IsAcitve = Supplier.IsAcitve;
                existingSupplier.IdentityNumber = Supplier.IdentityNumber;
                _context.SaveChanges();
            }
            return existingSupplier;
        }

        public bool DeleteSupplier(int id)
        {
            var supplier = _context.Supplier.FirstOrDefault(s => s.idSupplier == id);
            if (supplier != null)
            {
                _context.Supplier.Remove(supplier);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<dynamic> GetSupplierDetails()
        {
            return _context.Supplier.Include(s => s.Country)
                .Select(s => new
                {
                    s.idSupplier,
                    s.SupplierRef,
                    s.SupplierName,
                    s.ContactPerson,
                    s.Phone,
                    s.Email,
                    s.Address,
                    s.CountryId,
                    s.IsAcitve,
                    s.IdentityNumber,
                    CountryName = s.Country.CountryName
                }).Where(s => s.IsAcitve == true).ToList<dynamic>();
        }

        public Supplier SupplierByIdentity(string identity)
        {
            return _context.Supplier.Include(s => s.Country)
                .FirstOrDefault(s => s.IdentityNumber == identity);
           
        }
    }
}
