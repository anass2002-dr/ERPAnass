using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.CustomerService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerervice;

        public CustomerController(ICustomerService customerervice)
        {
            _customerervice = customerervice;
        }

        [HttpGet("GetCustomers")]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            return Ok(_customerervice.GetCustomers());
        }

        [HttpGet("GetCustomerDetails")]
        public ActionResult<IEnumerable<Customer>> GetCustomerDetails()
        {
            return Ok(_customerervice.GetCustomerDetails());
        }
        [HttpGet("GetCustomerById/{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerervice.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet("CustomerByIdentity/{identity}")]
        public ActionResult<Customer> CustomerByIdentity(string identity)
        {
            var customer = _customerervice.CustomerByIdentity(identity);

            return Ok(customer);
        }
        [HttpPost("AddCustomer")]
        public ActionResult<Customer> AddCustomer(CustomerDtos customer)
        {

            return _customerervice.AddCustomer(customer);
        }

        [HttpPut("UpdateCustomer/{id}")]
        public ActionResult<Customer> UpdateCustomer(int id, CustomerDtos customer)
        {
            customer.idCustomer = id;

            return _customerervice.UpdateCustomer(id, customer);
        }

        [HttpDelete("DeleteCustomer/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var result = _customerervice.DeleteCustomer(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
