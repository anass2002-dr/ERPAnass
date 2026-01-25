using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TaxConfigurationService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxConfigurationController : Controller
    {
        private readonly ITaxConfigurationService _taxService;

        public TaxConfigurationController(ITaxConfigurationService taxService)
        {
            _taxService = taxService;
        }

        [HttpGet("GetTaxConfigurations")]
        public ActionResult<IEnumerable<TaxConfiguration>> GetTaxConfigurations()
        {
            return _taxService.GetTaxConfigurations();
        }

        [HttpGet("GetTaxConfigurationById/{id}")]
        public ActionResult<TaxConfiguration> GetTaxConfigurationById(int id)
        {
            var result = _taxService.GetTaxConfigurationById(id);
            if (result == null)
            {
                return NotFound("Tax Configuration not found.");
            }
            return Ok(result);
        }

        [HttpPost("AddTaxConfiguration")]
        public ActionResult<TaxConfiguration> AddTaxConfiguration(TaxConfiguration taxConfiguration)
        {
            var result = _taxService.AddTaxConfiguration(taxConfiguration);
            return Ok(result);
        }

        [HttpPost("UpdateTaxConfiguration/{id}")]
        public ActionResult<TaxConfiguration> UpdateTaxConfiguration(TaxConfiguration taxConfiguration, int id)
        {
            var result = _taxService.UpdateTaxConfiguration(taxConfiguration, id);
             if (result == null)
            {
                return NotFound("Tax Configuration not found.");
            }
            return Ok(result);
        }

        [HttpDelete("DeleteTaxConfiguration/{id}")]
        public ActionResult<bool> DeleteTaxConfiguration(int id)
        {
            var result = _taxService.DeleteTaxConfiguration(id);
            if (!result)
            {
                return NotFound("Tax Configuration not found.");
            }
            return Ok(result);
        }
    }
}
