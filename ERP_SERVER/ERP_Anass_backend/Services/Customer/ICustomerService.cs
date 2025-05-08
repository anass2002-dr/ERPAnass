using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;

namespace ERP_Anass_backend.Services.CustomerService
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer AddCustomer(CustomerDtos CustomerDtos);
        Customer UpdateCustomer(int id, CustomerDtos CustomerDtos);
        bool DeleteCustomer(int id);
        Customer CustomerByIdentity(string identity);
        List<dynamic> GetCustomerDetails();
    }
}
