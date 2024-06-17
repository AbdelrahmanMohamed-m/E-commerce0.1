using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ApplicationLayer.Dtos
{
    public class OrderDto
    {

        public int OrderId { get; set; }
        public String OrderDate { get; set; } = "No Date";

        public String Status { get; set; } = "";

        public Decimal TotalAmount { get; set; } 

        public int AppUserId { get; set; }

    }

}
