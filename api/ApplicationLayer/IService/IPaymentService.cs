using api.ApplicationLayer.Dtos;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.IService
{
    public interface IPaymentService
    {

        public Task<PaymentDto> CreatePayment(Payment payment);

    }
}