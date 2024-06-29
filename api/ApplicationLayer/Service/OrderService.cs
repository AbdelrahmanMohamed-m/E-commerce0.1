using api.ApplicationLayer.Dtos;
using api.ApplicationLayer.IService;
using api.ApplicationLayer.Mappers;
using api.InfrastructureLayer.IRepos;

namespace api.ApplicationLayer.Service
{
    public class OrderService(IOrderRepo orderRepo) : IOrderService
    {
        private readonly IOrderRepo _orderRepo = orderRepo;

        public async Task<List<OrderDto>> GetOrders()
        {
            var orders = await _orderRepo.GetOrders();
            return orders.Select(order => order.OrderMapperToDto()).ToList();
        }

    }
}