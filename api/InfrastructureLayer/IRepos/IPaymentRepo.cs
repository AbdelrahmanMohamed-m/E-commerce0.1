using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Entities;

namespace api.InfrastructureLayer.IRepos
{
    public interface IPaymentRepo
    {

        // public Task<List<Payment>> GetPayments();

        // public Task<Payment> GetPayment(int id);

         public Task<Payment> CreatePayment(Payment payment);

        // public Task<Payment> UpdatePayment(Payment payment);

        // public Task<Payment> DeletePayment(int id);

        // //get payment order details by id 
        // public Task<Order> GetOrderDetails(int PaymentId);
    }
}