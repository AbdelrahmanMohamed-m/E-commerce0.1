using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataLayer.Entities;

namespace api.ApplicationLayer.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; } = "No Name";
        public string Description { get; set; } = "No Description";
        public decimal Price { get; set; }
        public string Image { get; set; } = "default.jpg";

        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "";

    }
}