using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.UnitOfMeasureService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureController : ControllerBase
    {
        private readonly IServiceUnitOfMeasure _uomService;

        public UnitOfMeasureController(IServiceUnitOfMeasure uomService)
        {
            _uomService = uomService;
        }

        [HttpGet("GetUnitOfMeasures")]
        public ActionResult<IEnumerable<UnitOfMeasure>> GetUnitOfMeasures()
        {
            return Ok(_uomService.GetUnitOfMeasures());
        }

        [HttpGet("GetUnitOfMeasureById/{id}")]
        public ActionResult<UnitOfMeasure> GetUnitOfMeasureById(int id)
        {
            var uom = _uomService.GetUnitOfMeasureById(id);
            if (uom == null) return NotFound();
            return Ok(uom);
        }

        [HttpPost("AddUnitOfMeasure")]
        public ActionResult<UnitOfMeasure> AddUnitOfMeasure(UnitOfMeasureDtos uom)
        {
            return Ok(_uomService.AddUnitOfMeasure(uom));
        }

        [HttpPut("UpdateUnitOfMeasure/{id}")]
        public ActionResult<UnitOfMeasure> UpdateUnitOfMeasure(int id, UnitOfMeasure uom)
        {
            var updated = _uomService.UpdateUnitOfMeasure(id, uom);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteUnitOfMeasure/{id}")]
        public IActionResult DeleteUnitOfMeasure(int id)
        {
            if (!_uomService.DeleteUnitOfMeasure(id)) return NotFound();
            return NoContent();
        }
    }
}
