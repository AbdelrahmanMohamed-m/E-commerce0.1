using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Data;
using api.DataLayer.Entities;
using api.InfrastructureLayer.IRepos;
using Microsoft.EntityFrameworkCore;

namespace api.InfrastructureLayer.Repos
{
    public class OrderRepo : IOrderRepo
    {

        private readonly ApplicationDBContenxt _context;
        public OrderRepo(ApplicationDBContenxt context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

    }
}