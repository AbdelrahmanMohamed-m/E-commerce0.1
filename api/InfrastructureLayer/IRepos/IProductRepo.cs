using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer;
using api.DataLayer.Entities;

namespace api.InfrastructureLayer.IRepos
{
    public interface IProductRepo
    {

        public Task<List<Product>> GetallProducts(QueryProductObject queryable);

    }
}