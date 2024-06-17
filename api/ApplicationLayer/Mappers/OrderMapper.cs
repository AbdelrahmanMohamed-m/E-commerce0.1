
using api.ApplicationLayer.Dtos;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.Mappers
{
    public static class OrderMapper
    {
       public static OrderDto OrderMapperToDto(this Order order)
        {
            return new OrderDto
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                AppUserId = order.AppUserId
            };
        }
    }
}