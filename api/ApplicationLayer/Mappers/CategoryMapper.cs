using api.ApplicationLayer.Dtos;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDto MapCategoryToCategoryDto(this Category category, Category c)
        {
            return new CategoryDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Products = category.Products.Select(ProductMapper.MapToProductCategoryDto).ToList()
            };
        }
    }
}