using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce_app_backend.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }
        public int Price { get; set; }
    }
}
