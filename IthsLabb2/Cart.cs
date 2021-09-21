using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Cart
    {
        private List<Products> _cart;
        public List<Products> cart { get { return _cart; } }

        public void ShowCart()
        {
            Console.WriteLine("Här är din kundvagn!");
            Console.WriteLine("");

            List<Products> productsList = new List<Products>();

            foreach (var items in productsList)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
