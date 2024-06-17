using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.DataLayer
{
    public class QueryProductObject
    {
        public string ProductName { get; set; } = "";
        public String? SortBy { get; set; } = "ProductName";
        public bool IsDesending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

    }
}