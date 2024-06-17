using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Data;
using api.DataLayer.Entities;
using api.InfrastructureLayer.IRepos;

namespace api.InfrastructureLayer.Repos
{
    public class PaymentRepo : IPaymentRepo
    {
        private readonly ApplicationDBContenxt _context;
        public PaymentRepo(ApplicationDBContenxt context)
        {
            _context = context;
        }
        public async Task<Payment> CreatePayment(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            return payment;
        }
    }
}