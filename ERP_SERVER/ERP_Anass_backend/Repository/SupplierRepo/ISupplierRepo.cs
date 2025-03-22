using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.SupplierRepo
{
    public interface ISupplierRepo
    {
        List<Supplier> GetSuppliers();
        Supplier GetSupplierById(int id);
        Supplier AddSupplier(Supplier supplier);
        Supplier UpdateSupplier(int id, Supplier supplier);
        bool DeleteSupplier(int id);
        Supplier SupplierByIdentity(string identity);
        List<dynamic> GetSupplierDetails();
    }
}
