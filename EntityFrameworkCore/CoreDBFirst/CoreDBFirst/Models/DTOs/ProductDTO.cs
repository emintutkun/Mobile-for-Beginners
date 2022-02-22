using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDBFirst.Models.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
