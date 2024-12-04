using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.PurchaseService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : Controller
    {
        private readonly IPurchaseService _purchaseService;
        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpGet("GetPurchaseById/{id}")]
        public ActionResult<Purchase> GetPurchaseById(int id)
        {
            return _purchaseService.GetPurchaseById(id);
        }
        [HttpGet("GetPurchases")]
        public ActionResult<IEnumerable<Purchase>> GetPurchases()
        {
            return _purchaseService.GetPurchases();
        }
        [HttpGet("GetPurchaseDetails")]
        public ActionResult<IEnumerable<dynamic>> GetPurchaseDetails()
        {
            return _purchaseService.GetPurchaseDetails();
        }
        [HttpPut("AddPurchase")]
        public ActionResult<Purchase> AddPurchase(PurchaseDtos purchaseDtos)
        {
            return _purchaseService.AddPurchase(purchaseDtos);
        }
        [HttpPost("UpdatePurchase/{id}")]
        public ActionResult<Purchase> UpdatePurchase(int id,PurchaseDtos purchaseDtos)
        {
            return _purchaseService.UpdatePurchase(id,purchaseDtos);
        }
        [HttpDelete("DeletePurchase/{id}")]
        public ActionResult<Boolean> DeletePurchase(int id)
        {
            return _purchaseService.DeletePurchase(id);
        }
    }
}
