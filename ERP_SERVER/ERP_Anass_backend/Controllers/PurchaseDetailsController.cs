using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Migrations;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.PurchaseService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseDetailsController : Controller
    {
        private readonly IPurchaseDetailsService _purchaseDetailsService;
        public PurchaseDetailsController(IPurchaseDetailsService PurchaseDetailsService)
        {
            _purchaseDetailsService = PurchaseDetailsService;
        }

        [HttpGet("GetPurchaseDetailsById/{id}")]
        public ActionResult<PurchaseDetails> GetPurchaseDetailsById(int id)
        {
            return _purchaseDetailsService.GetPurchasesDetailsById(id);
        }
        [HttpGet("GetPurchaseDetails")]
        public ActionResult<IEnumerable<PurchaseDetails>> GetPurchaseDetails()
        {
            return _purchaseDetailsService.GetPurchasesDetails();
        }
        [HttpGet("GetPurchaseDetailsByPurchase/{id}")]
        public ActionResult<IEnumerable<PurchaseDetails>> GetPurchaseDetailsByPurchase(int id)
        {
            return _purchaseDetailsService.GetPurchaseDetailsByPurchase(id);
        }
        [HttpPost("AddPurchaseDetails")]
        public ActionResult<PurchaseDetails> AddPurchaseDetails(PurchaseDetailsDtos PurchaseDetails)
        {
            return _purchaseDetailsService.AddPurchasesDetails(PurchaseDetails);
        }
        [HttpPost("UpdatePurchaseDetails/{id}")]
        public ActionResult<PurchaseDetails> UpdatePurchaseDetails(int id, PurchaseDetailsDtos purchaseDtos)
        {
            return _purchaseDetailsService.UpdatePurchasesDetails(id, purchaseDtos);
        }
        [HttpDelete("DeletePurchaseDetails/{id}")]
        public ActionResult<Boolean> DeletePurchaseDetails(int id)
        {
            return _purchaseDetailsService.DeletePurchasesDetails(id);
        }
    }
}
