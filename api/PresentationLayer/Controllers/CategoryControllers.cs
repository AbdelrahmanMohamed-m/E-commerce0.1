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
             throw new Exception("This is a test exception");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var categories = await categoryService.GetallCategories();
            return Ok(categories);  
        }

    }
}