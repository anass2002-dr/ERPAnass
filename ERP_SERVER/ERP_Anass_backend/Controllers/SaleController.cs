using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.SaleService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;
        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet("GetSaleById/{id}")]
        public ActionResult<Sale> GetSaleById(int id)
        {
            return _saleService.GetSaleById(id);
        }
        [HttpGet("checkRef/{reff}")]
        public ActionResult<Sale> checkRef(string reff)
        {
            return _saleService.checkRef(reff);
        }
        [HttpGet("GetSales")]
        public ActionResult<IEnumerable<Sale>> GetSales()
        {
            return _saleService.GetSales();
        }
        [HttpGet("GetSaleDetails")]
        public ActionResult<IEnumerable<dynamic>> GetSaleDetails()
        {
            return _saleService.GetSaleDetails();
        }
        [HttpPost("AddSale")]
        public ActionResult<Sale> AddSale(SaleDtos saleDtos)
        {
            return _saleService.AddSale(saleDtos);
        }
        [HttpPost("UpdateSale/{id}")]
        public ActionResult<Sale> UpdateSale(int id,SaleDtos saleDtos)
        {
            return _saleService.UpdateSale(id,saleDtos);
        }
        [HttpDelete("DeleteSale/{id}")]
        public ActionResult<Boolean> DeleteSale(int id)
        {
            return _saleService.DeleteSale(id);
        }
    }
}
