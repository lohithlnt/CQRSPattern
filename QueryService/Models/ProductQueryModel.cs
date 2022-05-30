using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueryService.Models
{
    public class ProductQueryModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
