using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.BillOfMaterialsService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillOfMaterialsController : ControllerBase
    {
        private readonly IServiceBillOfMaterials _bomService;

        public BillOfMaterialsController(IServiceBillOfMaterials bomService)
        {
            _bomService = bomService;
        }

        [HttpGet("GetBOMs")]
        public ActionResult<IEnumerable<dynamic>> GetBOMs()
        {
            return Ok(_bomService.GetBOMsDetails());
        }

        [HttpGet("GetBOMById/{id}")]
        public ActionResult<BillOfMaterials> GetBOMById(int id)
        {
            var bom = _bomService.GetBOMById(id);
            if (bom == null) return NotFound();
            return Ok(bom);
        }

        [HttpPost("AddBOM")]
        public ActionResult<BillOfMaterials> AddBOM(BillOfMaterialsDtos bom)
        {
            return Ok(_bomService.AddBOM(bom));
        }

        [HttpPut("UpdateBOM/{id}")]
        public ActionResult<BillOfMaterials> UpdateBOM(int id, BillOfMaterials bom)
        {
            var updated = _bomService.UpdateBOM(id, bom);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteBOM/{id}")]
        public IActionResult DeleteBOM(int id)
        {
            if (!_bomService.DeleteBOM(id)) return NotFound();
            return NoContent();
        }
    }
}
