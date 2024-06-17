

using api.ApplicationLayer.IService;
using api.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.PresentationLayer.Controllers
{
    [Route("api/Payment")]
    [ApiController]
    public class PaymentController(IPaymentService paymentService) : ControllerBase
    {
        private readonly IPaymentService _paymentService = paymentService;


        [HttpPost]
        public async Task<IActionResult> CreatePayment([FromBody] Payment payment)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _paymentService.CreatePayment(payment);

            return result != null ? Ok(result) : BadRequest();

        }
    }

}