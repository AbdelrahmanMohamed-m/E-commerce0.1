using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ApplicationLayer.Dtos
{
    public class PaymentDto
    {
         
       public int PaymentId { get; set; }

        public String PaymentMethod { get; set; } = "";

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        public decimal PaymentAmount { get; set; } = 0;

        public List<OrderDto> Order { get; set; } = [];
    }
}