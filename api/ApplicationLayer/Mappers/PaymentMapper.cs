
using api.ApplicationLayer.Dtos;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.Mappers
{
    public  static class PaymentMapper
    {
         
         public static PaymentDto PaymentToPaymentDto(this Payment payment){

            return new PaymentDto{
            PaymentAmount = payment.PaymentAmount,
            PaymentDate = payment.PaymentDate,
            PaymentId = payment.PaymentId,
            PaymentMethod = payment.PaymentMethod,
            Order = payment.Order.Select(o => o.OrderMapperToDto()).ToList()
            };
         }
    }
}