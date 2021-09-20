using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Store
    {
        public void Products()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till våra varor! Välj nedan vad du vill köpa");
            Console.WriteLine("");

            List<Products> productsList = new List<Products>();
            productsList.Add(new Products() { Product = "Banan" });
            productsList.Add(new Products() { Product = "Äpple" });
            productsList.Add(new Products() { Product = "Päron" });

            Console.WriteLine($"1. {productsList[0]}");
            Console.WriteLine($"2. {productsList[1]}");
            Console.WriteLine($"3. {productsList[2]}");

        }
    }
}
