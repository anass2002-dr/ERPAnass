using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.WarehouseService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IServiceWarehouse _warehouseService;

        public WarehouseController(IServiceWarehouse warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpGet("GetWarehouses")]
        public ActionResult<IEnumerable<dynamic>> GetWarehouses()
        {
            return Ok(_warehouseService.GetWarehousesDetails());
        }

        [HttpGet("GetWarehouseById/{id}")]
        public ActionResult<Warehouse> GetWarehouseById(int id)
        {
            var warehouse = _warehouseService.GetWarehouseById(id);
            if (warehouse == null)
            {
                return NotFound();
            }
            return Ok(warehouse);
        }

        [HttpPost("AddWarehouse")]
        public ActionResult<Warehouse> AddWarehouse(WarehouseDtos warehouse)
        {
            return Ok(_warehouseService.AddWarehouse(warehouse));
        }

        [HttpPut("UpdateWarehouse/{id}")]
        public ActionResult<Warehouse> UpdateWarehouse(int id, Warehouse warehouse)
        {
            try
            {
                 var updated = _warehouseService.UpdateWarehouse(id, warehouse);
                 if (updated == null) return NotFound();
                 return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteWarehouse/{id}")]
        public IActionResult DeleteWarehouse(int id)
        {
            var result = _warehouseService.DeleteWarehouse(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
