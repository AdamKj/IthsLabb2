using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Products
    {
        public string Product { get; set; }
        public double Price { get; set; }

        public Products(string product, double price)
        {
            Product = product;
            Price = price;
        }
    }
}
