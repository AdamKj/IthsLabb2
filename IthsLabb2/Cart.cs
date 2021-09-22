using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Cart
    {
        public void ShowCart()
        {
            Console.Clear();
            Console.WriteLine("Här är din kundvagn!");
            Console.WriteLine("");

            ExistingCustomer customerCart = new ExistingCustomer();
            customerCart.Knatte();
            Console.WriteLine("");
            Console.WriteLine("Vill du Betala och lämna butiken, Handla mer eller Logga ut?");
            Console.WriteLine("");
            CartAction();
        }

        public void CartAction()
        {
            Console.WriteLine("Tryck 1 för att Betala och lämna butiken");
            Console.WriteLine("Tryck 2 för att Handla mer");
            Console.WriteLine("Tryck 3 för att Logga ut");

            string input = Console.ReadLine();
            Store store = new Store();
            DrawBoxes meny = new DrawBoxes();

            switch (input)
            {
                case "1":
                    break;
                case "2":
                    store.Products();
                    break;
                case "3":
                    Console.Clear();
                    meny.DrawBoxMeny1();
                    input = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Vänligen välj en av de ovanstående alternativen");
                    input = Console.ReadLine();
                    break;
            }
        }
    }
}
