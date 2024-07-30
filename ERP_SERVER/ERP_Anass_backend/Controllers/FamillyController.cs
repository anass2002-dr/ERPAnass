using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.FamillyServices;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamillyController : ControllerBase
    {
        private readonly IFamillyService _famillyService;

        public FamillyController(IFamillyService famillyService)
        {
            _famillyService = famillyService;
        }

        [HttpGet("GetFamillys")]
        public ActionResult<IEnumerable<Familly>> GetFamillys()
        {
            return Ok(_famillyService.GetFamillys());
        }

        [HttpGet("GetFamillyById/{id}")]
        public ActionResult<Familly> GetFamillyById(int id)
        {
            var familly = _famillyService.GetFamilyById(id);
            if (familly == null)
            {
                return NotFound();
            }
            return Ok(familly);
        }

        [HttpPost("AddFamilly")]
        public ActionResult<Familly> AddFamilly(Familly familly)
        {
            _famillyService.AddFamilly(familly);
            return CreatedAtAction(nameof(GetFamillyById), new { id = familly.idFamilly }, familly);
        }

        [HttpPut("UpdateFamilly/{id}")]
        public ActionResult<Familly> UpdateFamilly(int id, Familly familly)
        {
            familly.idFamilly = id;
            
            return _famillyService.UpdateFamilly(familly);
        }

        [HttpDelete("DeleteFamilly/{id}")]
        public IActionResult DeleteFamilly(int id)
        {
            var result = _famillyService.DeleteFamilly(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
