
using api.ApplicationLayer.Dtos;
using api.ApplicationLayer.IService;
using api.ApplicationLayer.Mappers;
using api.InfrastructureLayer.IRepos;

namespace api.ApplicationLayer.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryService(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<List<CategoryDto>> GetallCategories()
        {
            var categories = await _categoryRepo.GetallCategories();
            return categories.Select(c => c.MapCategoryToCategoryDto(c)).ToList();
        }
    }
}