using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Repository.CustomerRepo
{
    public interface ICustomerRepo
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer AddCustomer(Customer supplier);
        Customer UpdateCustomer(int id, Customer supplier);
        bool DeleteCustomer(int id);
        Customer CustomerByIdentity(string identity);
        List<dynamic> GetCustomerDetails();
    }
}
