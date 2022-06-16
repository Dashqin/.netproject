using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int DiscountPrecent { get; set; }
        public string Description { get; set; }
        public bool IsAvailabe { get; set; }

    }
}
