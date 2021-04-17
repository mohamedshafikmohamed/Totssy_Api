using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Totssy_Api.Models
{
    public class Product
    {
        public string Name { get; set; }
        public byte[] Img { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
