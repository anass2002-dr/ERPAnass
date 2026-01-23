using ERP_Anass_backend.DTOs;
using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.TenantService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly IServiceTenant _tenantService;

        public TenantController(IServiceTenant tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet("GetTenants")]
        public ActionResult<IEnumerable<Tenant>> GetTenants()
        {
            return Ok(_tenantService.GetTenants());
        }

        [HttpGet("GetTenantById/{id}")]
        public ActionResult<Tenant> GetTenantById(Guid id)
        {
            var tenant = _tenantService.GetTenantById(id);
            if (tenant == null) return NotFound();
            return Ok(tenant);
        }

        [HttpPost("AddTenant")]
        public ActionResult<Tenant> AddTenant(TenantDtos tenant)
        {
            return Ok(_tenantService.AddTenant(tenant));
        }

        [HttpPut("UpdateTenant/{id}")]
        public ActionResult<Tenant> UpdateTenant(Guid id, Tenant tenant)
        {
            var updated = _tenantService.UpdateTenant(id, tenant);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("DeleteTenant/{id}")]
        public IActionResult DeleteTenant(Guid id)
        {
            if (!_tenantService.DeleteTenant(id)) return NotFound();
            return NoContent();
        }
    }
}
