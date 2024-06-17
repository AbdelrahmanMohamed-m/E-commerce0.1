using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.ApplicationLayer.Dtos
{
    public class ProductCategoryDto
    {

        public string Name { get; set; } = "No Name";
        public string Description { get; set; } = "No Description";
        public decimal Price { get; set; }
        public string Image { get; set; } = "default.jpg";

        public int Stock { get; set; }
    }
}