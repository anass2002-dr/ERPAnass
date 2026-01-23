using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.AppConfigurationService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppConfigurationController : ControllerBase
    {
        private readonly IServiceAppConfiguration _appConfigService;

        public AppConfigurationController(IServiceAppConfiguration appConfigService)
        {
            _appConfigService = appConfigService;
        }

        [HttpGet("GetAppConfigurations")]
        public ActionResult<IEnumerable<AppConfiguration>> GetAppConfigurations()
        {
            return Ok(_appConfigService.GetAppConfigurations());
        }

        [HttpGet("GetAppConfigurationById/{id}")]
        public ActionResult<AppConfiguration> GetAppConfigurationById(int id)
        {
            var config = _appConfigService.GetAppConfigurationById(id);
            if (config == null) return NotFound();
            return Ok(config);
        }

        [HttpPost("AddAppConfiguration")]
        public ActionResult<AppConfiguration> AddAppConfiguration(AppConfigurationDtos appConfig)
        {
            return Ok(_appConfigService.AddAppConfiguration(appConfig));
        }

        [HttpPut("UpdateAppConfiguration/{id}")]
        public ActionResult<AppConfiguration> UpdateAppConfiguration(int id, AppConfiguration appConfig)
        {
            var updated = _appConfigService.UpdateAppConfiguration(id, appConfig);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteAppConfiguration/{id}")]
        public IActionResult DeleteAppConfiguration(int id)
        {
            if (!_appConfigService.DeleteAppConfiguration(id)) return NotFound();
            return NoContent();
        }

        [HttpGet("GetConfigurationValue/{key}")]
        public ActionResult<string> GetConfigurationValue(string key)
        {
            var value = _appConfigService.GetConfigurationValue(key);
            if (value == null) return NotFound();
            return Ok(value);
        }
    }
}
