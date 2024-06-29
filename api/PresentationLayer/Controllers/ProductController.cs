using api.ApplicationLayer.IService;
using api.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace api.PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/Product")]
    public class ProductController(IProductService productService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] QueryProductObject queryable)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var products = await productService.GetAllProducts(queryable);
            return Ok(products);
        }
    }
}