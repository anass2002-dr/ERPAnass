using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.SupplierService
{
    public interface ISupplierService
    {
        List<Supplier> GetSuppliers();
        Supplier GetSupplierById(int id);
        Supplier AddSupplier(SupplierDtos SupplierDtos);
        Supplier UpdateSupplier(int id, SupplierDtos SupplierDtos);
        bool DeleteSupplier(int id);
        List<dynamic> GetSupplierDetails();
    }
}
