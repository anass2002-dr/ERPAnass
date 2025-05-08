using ERP_Anass_backend.DTOs;
//using ERP_Anass_backend.Migrations;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.SaleService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleDetailsController : Controller
    {
        private readonly ISaleDetailsService _saleDetailsService;
        public SaleDetailsController(ISaleDetailsService SaleDetailsService)
        {
            _saleDetailsService = SaleDetailsService;
        }

        [HttpGet("GetSaleDetailsById/{id}")]
        public ActionResult<SaleDetails> GetSaleDetailsById(int id)
        {
            return _saleDetailsService.GetSalesDetailsById(id);
        }
        [HttpGet("GetSaleDetails")]
        public ActionResult<IEnumerable<SaleDetails>> GetSaleDetails()
        {
            return _saleDetailsService.GetSalesDetails();
        }
        [HttpGet("GetSaleDetailsBySale/{id}")]
        public ActionResult<IEnumerable<dynamic>> GetSaleDetailsBySale(int id)
        {
            return _saleDetailsService.GetSaleDetailsBySale(id);
        }
        [HttpPost("AddSaleDetails")]
        public ActionResult<SaleDetails> AddSaleDetails(SaleDetailsDtos SaleDetails)
        {
            return _saleDetailsService.AddSalesDetails(SaleDetails);
        }
        [HttpPost("UpdateSaleDetails/{id}")]
        public ActionResult<SaleDetails> UpdateSaleDetails(int id, SaleDetailsDtos saleDtos)
        {
            return _saleDetailsService.UpdateSalesDetails(id, saleDtos);
        }
        [HttpDelete("DeleteSaleDetails/{id}")]
        public ActionResult<Boolean> DeleteSaleDetails(int id)
        {
            return _saleDetailsService.DeleteSalesDetails(id);
        }
    }
}
