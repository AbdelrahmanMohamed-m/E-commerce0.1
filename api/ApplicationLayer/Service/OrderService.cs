using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.Dtos;
using api.ApplicationLayer.IService;
using api.ApplicationLayer.Mappers;
using api.InfrastructureLayer.IRepos;

namespace api.ApplicationLayer.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepo;
        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public async Task<List<OrderDto>> GetOrders()
        {
            var orders = await _orderRepo.GetOrders();
            return orders.Select(order => order.OrderMapperToDto()).ToList();
        }

    }
}