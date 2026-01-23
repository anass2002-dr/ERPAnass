using ERP_Anass_backend.Models;
using ERP_Anass_backend.Services.BrandService;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Anass_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetBrands")]
        public ActionResult<IEnumerable<Brand>> GetBrands()
        {
            return Ok(_brandService.GetBrands());
        }

        [HttpGet("GetBrandById/{id}")]
        public ActionResult<Brand> GetBrandById(int id)
        {
            var brand = _brandService.GetBrandById(id);
            if (brand == null)
            {
                return NotFound();
            }
            return Ok(brand);
        }

        [HttpPost("AddBrand")]
        public ActionResult<Brand> AddBrand(Brand brand)
        {
            return Ok(_brandService.AddBrand(brand));
        }

        [HttpPut("UpdateBrand/{id}")]
        public ActionResult<Brand> UpdateBrand(int id, Brand brand)
        {
            var updatedBrand = _brandService.UpdateBrand(id, brand);
            if (updatedBrand == null)
            {
                return NotFound();
            }
            return Ok(updatedBrand);
        }

        [HttpDelete("DeleteBrand/{id}")]
        public IActionResult DeleteBrand(int id)
        {
            var result = _brandService.DeleteBrand(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
