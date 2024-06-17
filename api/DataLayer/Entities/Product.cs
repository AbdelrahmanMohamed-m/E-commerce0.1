using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.DataLayer.Entities
{
    public class Product
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; } = "No Name";

        public string ProductDescription { get; set; } = "No Description";

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; } = 0;

        public string ProductImage { get; set; } = "default.jpg";

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        // Navigation Property
        public Category Category { get; set; } = new Category();

        public List<OrderItem> OrderItems { get; set; } = [];

    }
}