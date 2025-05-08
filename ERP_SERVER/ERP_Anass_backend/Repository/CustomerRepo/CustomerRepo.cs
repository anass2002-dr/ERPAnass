using ERP_Anass_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ERP_Anass_backend.Repository.CustomerRepo
{
    public class CustomerRepo:ICustomerRepo
    {
        private readonly DbContextERP _context;

        public CustomerRepo(DbContextERP context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.Where(s => s.IsAcitve == true).ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return _context.Customer.Include(s => s.Country)
                .FirstOrDefault(s => s.idCustomer == id);
        }

        public Customer AddCustomer(Customer supplier)
        {
            _context.Customer.Add(supplier);
            _context.SaveChanges();
            return supplier;
        }

        public Customer UpdateCustomer(int id, Customer Customer)
        {
            var existingCustomer = _context.Customer.FirstOrDefault(s => s.idCustomer == id);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerRef = Customer.CustomerRef;
                existingCustomer.CustomerName = Customer.CustomerName;
                existingCustomer.ContactPerson = Customer.ContactPerson;
                existingCustomer.Phone = Customer.Phone;
                existingCustomer.Email = Customer.Email;
                existingCustomer.Address = Customer.Address;
                existingCustomer.CountryId = Customer.CountryId;
                existingCustomer.CityID = Customer.CityID;
                existingCustomer.IsAcitve = Customer.IsAcitve;
                existingCustomer.IdentityNumber = Customer.IdentityNumber;
                _context.SaveChanges();
            }
            return existingCustomer;
        }

        public bool DeleteCustomer(int id)
        {
            var supplier = _context.Customer.FirstOrDefault(s => s.idCustomer == id);
            if (supplier != null)
            {
                _context.Customer.Remove(supplier);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<dynamic> GetCustomerDetails()
        {
            return _context.Customer.Include(s => s.Country)
                .Select(s => new
                {
                    s.idCustomer,
                    s.CustomerRef,
                    s.CustomerName,
                    s.ContactPerson,
                    s.Phone,
                    s.Email,
                    s.Address,
                    s.CountryId,
                    s.City.CityID,
                    s.IsAcitve,
                    s.IdentityNumber,
                    CityName = s.City.CityName,
                    CountryName = s.Country.CountryName
                }).Where(s => s.IsAcitve == true).ToList<dynamic>();
        }

        public Customer CustomerByIdentity(string identity)
        {
            return _context.Customer.Include(s => s.Country)
                .FirstOrDefault(s => s.IdentityNumber == identity);

        }
    }
}
