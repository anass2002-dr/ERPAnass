using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.SupplierService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : Controller
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet("GetSuppliers")]
        public ActionResult<IEnumerable<Supplier>> GetSuppliers()
        {
            return Ok(_supplierService.GetSuppliers());
        }

        [HttpGet("GetSupplierDetails")]
        public ActionResult<IEnumerable<Supplier>> GetSupplierDetails()
        {
            return Ok(_supplierService.GetSupplierDetails());
        }
        [HttpGet("GetSupplierById/{id}")]
        public ActionResult<Supplier> GetSupplierById(int id)
        {
            var supplier = _supplierService.GetSupplierById(id);
            if (supplier == null)
            {
                return NotFound();
            }
            return Ok(supplier);
        }

        [HttpGet("SupplierByIdentity/{identity}")]
        public ActionResult<Supplier> SupplierByIdentity(string identity)
        {
            var supplier = _supplierService.SupplierByIdentity(identity);
            
            return Ok(supplier);
        }
        [HttpPost("AddSupplier")]
        public ActionResult<Supplier> AddSupplier(SupplierDtos supplier)
        {

            return _supplierService.AddSupplier(supplier);
        }

        [HttpPut("UpdateSupplier/{id}")]
        public ActionResult<Supplier> UpdateSupplier(int id, SupplierDtos supplier)
        {
            supplier.idSupplier = id;

            return _supplierService.UpdateSupplier(id,supplier);
        }

        [HttpDelete("DeleteSupplier/{id}")]
        public IActionResult DeleteSupplier(int id)
        {
            var result = _supplierService.DeleteSupplier(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
