using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Entities;

namespace api.InfrastructureLayer.IRepos
{
    public interface IOrderRepo
    {
        
        public Task<List<Order>> GetOrders();
    }
}