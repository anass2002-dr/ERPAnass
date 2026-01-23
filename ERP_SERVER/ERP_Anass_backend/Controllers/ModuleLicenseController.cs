using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.ModuleLicenseService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleLicenseController : ControllerBase
    {
        private readonly IServiceModuleLicense _moduleLicenseService;

        public ModuleLicenseController(IServiceModuleLicense moduleLicenseService)
        {
            _moduleLicenseService = moduleLicenseService;
        }

        [HttpGet("GetModuleLicenses")]
        public ActionResult<IEnumerable<ModuleLicense>> GetModuleLicenses()
        {
            return Ok(_moduleLicenseService.GetModuleLicenses());
        }

        [HttpGet("GetModuleLicenseById/{id}")]
        public ActionResult<ModuleLicense> GetModuleLicenseById(int id)
        {
            var ml = _moduleLicenseService.GetModuleLicenseById(id);
            if (ml == null) return NotFound();
            return Ok(ml);
        }

        [HttpPost("AddModuleLicense")]
        public ActionResult<ModuleLicense> AddModuleLicense(ModuleLicenseDtos moduleLicense)
        {
            return Ok(_moduleLicenseService.AddModuleLicense(moduleLicense));
        }

        [HttpPut("UpdateModuleLicense/{id}")]
        public ActionResult<ModuleLicense> UpdateModuleLicense(int id, ModuleLicense moduleLicense)
        {
            var updated = _moduleLicenseService.UpdateModuleLicense(id, moduleLicense);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteModuleLicense/{id}")]
        public IActionResult DeleteModuleLicense(int id)
        {
            if (!_moduleLicenseService.DeleteModuleLicense(id)) return NotFound();
            return NoContent();
        }

        [HttpGet("IsModuleActive/{moduleName}")]
        public ActionResult<bool> IsModuleActive(string moduleName)
        {
            return Ok(_moduleLicenseService.IsModuleActive(moduleName));
        }
    }
}
