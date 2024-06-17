using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer;
using api.DataLayer.Data;
using api.DataLayer.Entities;
using api.InfrastructureLayer.IRepos;
using api.Migrations;
using Microsoft.EntityFrameworkCore;

namespace api.InfrastructureLayer.Repos
{
    public class ProductRepo(ApplicationDBContenxt context) : IProductRepo
    {

        private readonly ApplicationDBContenxt _context = context;

        public Task<List<Product>> GetallProducts(QueryProductObject queryable)
        {
            return _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}