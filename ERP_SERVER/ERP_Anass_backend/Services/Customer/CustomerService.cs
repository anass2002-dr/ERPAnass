using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Repository.CustomerRepo;

namespace ERP_Anass_backend.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _CustomerRepo;

        public CustomerService(ICustomerRepo CustomerRepo)
        {
            _CustomerRepo = CustomerRepo;
        }

        public List<Customer> GetCustomers()
        {
            
            return _CustomerRepo.GetCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return _CustomerRepo.GetCustomerById(id);
        }

        public Customer AddCustomer(CustomerDtos Customer)
        {
            var sup = new Customer
            {
                CustomerName = Customer.CustomerName,
                CustomerRef = Customer.CustomerRef,
                ContactPerson = Customer.Phone,
                Phone = Customer.Phone,
                Address = Customer.Address,
                Email = Customer.Email,
                CountryId=Customer.CountryId,
                CityID=Customer.CityID,
                IsAcitve = Customer.IsAcitve,
                IdentityNumber = Customer.IdentityNumber

            };
            return _CustomerRepo.AddCustomer(sup);
        }

        public Customer UpdateCustomer(int id, CustomerDtos CustomerDtos)
        {
            var existingElement = _CustomerRepo.GetCustomerById(id);
            if (existingElement != null)
            {
                existingElement.CustomerName = string.IsNullOrEmpty(CustomerDtos.CustomerName) ? existingElement.CustomerName : CustomerDtos.CustomerName;
                existingElement.CustomerRef = string.IsNullOrEmpty(CustomerDtos.CustomerRef) ? existingElement.CustomerRef : CustomerDtos.CustomerRef;
                existingElement.ContactPerson = string.IsNullOrEmpty(CustomerDtos.ContactPerson) ? existingElement.ContactPerson : CustomerDtos.ContactPerson;
                existingElement.Phone = string.IsNullOrEmpty(CustomerDtos.Phone) ? existingElement.Phone : CustomerDtos.Phone;
                existingElement.Address = string.IsNullOrEmpty(CustomerDtos.Address) ? existingElement.Address : CustomerDtos.Address;
                existingElement.Email = string.IsNullOrEmpty(CustomerDtos.Email) ? existingElement.Email : CustomerDtos.Email;
                existingElement.IdentityNumber = string.IsNullOrEmpty(CustomerDtos.IdentityNumber) ? existingElement.IdentityNumber : CustomerDtos.IdentityNumber;
                existingElement.CountryId = CustomerDtos.CountryId == 0 ? existingElement.CountryId : CustomerDtos.CountryId;
                existingElement.CityID = CustomerDtos.CityID == 0 ? existingElement.CityID : CustomerDtos.CityID;
                existingElement.IsAcitve = CustomerDtos.IsAcitve;
            }
            return _CustomerRepo.UpdateCustomer(id, existingElement);
        }

        public bool DeleteCustomer(int id)
        {
            var sup=new CustomerDtos();
            sup.IsAcitve = false;
            try
            {   
                UpdateCustomer(id, sup);
                 
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<dynamic> GetCustomerDetails()
        {
            return _CustomerRepo.GetCustomerDetails();
        }

        public Customer CustomerByIdentity(string identity)
        {
            return _CustomerRepo.CustomerByIdentity(identity);
            
        }
    }
}
