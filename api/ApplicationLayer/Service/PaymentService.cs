using api.ApplicationLayer.Dtos;
using api.ApplicationLayer.IService;
using api.ApplicationLayer.Mappers;
using api.DataLayer.Entities;
using api.InfrastructureLayer.IRepos;

namespace api.ApplicationLayer.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepo _paymentRepo;
        public PaymentService(IPaymentRepo paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }
        public async Task<PaymentDto> CreatePayment(Payment payment)
        {
            var paymentDto =  await _paymentRepo.CreatePayment(payment);
            return payment.PaymentToPaymentDto();
        }

    }
}