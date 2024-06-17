using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DataLayer.Entities
{
    public class Category
    {

        public string CategoryName { get; set; } = "";

        public int CategoryId { get; set; }

        public List<Product> Products { get; set; } = [];
    }
}