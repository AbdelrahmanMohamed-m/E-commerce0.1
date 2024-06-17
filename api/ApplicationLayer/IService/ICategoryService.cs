using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.Dtos;

namespace api.ApplicationLayer.IService
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetallCategories();
        
    }
}