using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.StockMovementService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockMovementController : ControllerBase
    {
        private readonly IServiceStockMovement _stockMovementService;

        public StockMovementController(IServiceStockMovement stockMovementService)
        {
            _stockMovementService = stockMovementService;
        }

        [HttpGet("GetStockMovements")]
        public ActionResult<IEnumerable<dynamic>> GetStockMovements()
        {
             return Ok(_stockMovementService.GetStockMovementsDetails());
        }

        [HttpPost("ReceivePurchase/{purchaseId}/{warehouseId}")]
        public async Task<ActionResult<bool>> ReceivePurchase(int purchaseId, int warehouseId)
        {
            var result = await _stockMovementService.ReceivePurchaseItems(purchaseId, warehouseId);
            return Ok(result);
        }

        [HttpGet("GetStockMovementById/{id}")]
        public ActionResult<StockMovement> GetStockMovementById(int id)
        {
             var sm = _stockMovementService.GetStockMovementById(id);
             if (sm == null) return NotFound();
             return Ok(sm);
        }

        [HttpPost("AddStockMovement")]
        public ActionResult<StockMovement> AddStockMovement(StockMovementDtos stockMovement)
        {
             return Ok(_stockMovementService.AddStockMovement(stockMovement));
        }

        [HttpPut("UpdateStockMovement/{id}")]
        public ActionResult<StockMovement> UpdateStockMovement(int id, StockMovement stockMovement)
        {
             var updated = _stockMovementService.UpdateStockMovement(id, stockMovement);
             if (updated == null) return NotFound();
             return Ok(updated);
        }

        [HttpDelete("DeleteStockMovement/{id}")]
        public IActionResult DeleteStockMovement(int id)
        {
             var result = _stockMovementService.DeleteStockMovement(id);
             if (!result) return NotFound();
             return NoContent();
        }
    }
}
