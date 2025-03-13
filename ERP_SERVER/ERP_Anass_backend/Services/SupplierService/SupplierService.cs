using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.SupplierRepo;

namespace ERP_Anass_backend.Services.SupplierService
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepo _supplierRepo;

        public SupplierService(ISupplierRepo supplierRepo)
        {
            _supplierRepo = supplierRepo;
        }

        public List<Supplier> GetSuppliers()
        {
            
            return _supplierRepo.GetSuppliers();
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepo.GetSupplierById(id);
        }

        public Supplier AddSupplier(SupplierDtos supplier)
        {
            var sup = new Supplier
            {
                SupplierName = supplier.SupplierName,
                SupplierRef = supplier.SupplierRef,
                ContactPerson = supplier.Phone,
                Phone = supplier.Phone,
                Address = supplier.Address,
                Email = supplier.Email,
                CountryId=supplier.CountryId,
                IsAcitve = supplier.IsAcitve

        };
            return _supplierRepo.AddSupplier(sup);
        }

        public Supplier UpdateSupplier(int id, SupplierDtos supplierDtos)
        {
            var existingElement = _supplierRepo.GetSupplierById(id);
            if (existingElement != null)
            {
                existingElement.SupplierName = string.IsNullOrEmpty(supplierDtos.SupplierName) ? existingElement.SupplierName : supplierDtos.SupplierName;
                existingElement.SupplierRef = string.IsNullOrEmpty(supplierDtos.SupplierRef) ? existingElement.SupplierRef : supplierDtos.SupplierRef;
                existingElement.ContactPerson = string.IsNullOrEmpty(supplierDtos.ContactPerson) ? existingElement.ContactPerson : supplierDtos.ContactPerson;
                existingElement.Phone = string.IsNullOrEmpty(supplierDtos.Phone) ? existingElement.Phone : supplierDtos.Phone;
                existingElement.Address = string.IsNullOrEmpty(supplierDtos.Address) ? existingElement.Address : supplierDtos.Address;
                existingElement.Email = string.IsNullOrEmpty(supplierDtos.Email) ? existingElement.Email : supplierDtos.Email;
                existingElement.CountryId = supplierDtos.CountryId == 0 ? existingElement.CountryId : supplierDtos.CountryId;
                existingElement.IsAcitve = supplierDtos.IsAcitve;
            }
            return _supplierRepo.UpdateSupplier(id, existingElement);
        }

        public bool DeleteSupplier(int id)
        {
            var sup=new SupplierDtos();
            sup.IsAcitve = false;
            try
            {   
                UpdateSupplier(id, sup);
                 
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<dynamic> GetSupplierDetails()
        {
            return _supplierRepo.GetSupplierDetails();
        }
    }
}
