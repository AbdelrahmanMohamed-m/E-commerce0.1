using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.DataLayer.Entities
{
    public class Order
    {

        public int OrderId { get; set; }
        public String OrderDate { get; set; } = "No Date";

        public String Status { get; set; } = "No Status"; 
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; } 

        public int AppUserId { get; set; }

        // Navigation Property
        public AppUser User { get; set; } = new AppUser();

        public List<OrderItem> OrderItems { get; set; } = [];
    }

}