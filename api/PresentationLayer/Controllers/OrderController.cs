using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ApplicationLayer.IService;
using Microsoft.AspNetCore.Mvc;

namespace api.PresentationLayer.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController(IOrderService orderService) : ControllerBase
    {
        private readonly IOrderService _orderService = orderService;

        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _orderService.GetOrders();
            return Ok(orders);
        }
    }
}