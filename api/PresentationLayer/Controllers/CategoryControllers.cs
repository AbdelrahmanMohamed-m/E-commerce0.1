using api.ApplicationLayer.IService;
using Microsoft.AspNetCore.Mvc;

namespace api.PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryControllers(ICategoryService categoryService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var categories = await categoryService.GetallCategories();
            return Ok(categories);  
        }

    }
}