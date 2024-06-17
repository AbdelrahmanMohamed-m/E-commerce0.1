using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.Mappers;
using api.DataLayer.Data;
using api.DataLayer.Entities;
using api.InfrastructureLayer.IRepos;
using Microsoft.EntityFrameworkCore;

namespace api.InfrastructureLayer.Repos
{
    public class CategoryRepo : ICategoryRepo
    { 
        private readonly ApplicationDBContenxt _context;
        public CategoryRepo(ApplicationDBContenxt context)
        {
            _context = context;
        }
      
        public async Task<List<Category>> GetallCategories()
        {
            return await _context.Categories.Include(c=>c.Products).ToListAsync();
        }
    }
}