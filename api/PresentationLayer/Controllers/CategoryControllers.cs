using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.IService;
using Microsoft.AspNetCore.Mvc;

namespace api.PresentationLayer.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryControllers(ICategoryService categoryService) : ControllerBase
    {

        private readonly ICategoryService _categoryService = categoryService;

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var categories = await _categoryService.GetallCategories();
            return Ok(categories);
        }

    }
}