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
            Console.WriteLine("Tryck på 0 för att gå tillbaka");

            string input = Console.ReadLine();
            DrawBoxes meny = new DrawBoxes();

            while (input != "0")
            {
                switch (input)
                {
                    case "1":
                        Banan();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "2":
                        Äpple();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "3":
                        Päron();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Vad vill du handla här näst?: ");
                        input = Console.ReadLine();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        input = Console.ReadLine();
                        break;
                }
            }
            meny.StoreDrawBox();
            input = Console.ReadLine();
        }

        public void Banan()
        {
            int banan = 17;
            Console.Write("En banan kostar 17kr, hur många vill du köpa?: ");
            int input;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Vänligen skriv bara in antalet du vill köpa som en siffra");
                input = int.Parse(Console.ReadLine());
                
            }
            int sum = input * banan;
            Console.WriteLine($"Du har köpt {input}st bananer som totalt kostar {sum}kr");
            Cart numberOfItems = new Cart();
            Cart sumOfItems = new Cart();
            //sumOfItems.cart += sum;
            //numberOfItems.cart += input;
            
        }
        public void Äpple()
        {
            int apple = 9;
            Console.Write("Ett äpple kostar 9kr, hur många vill du köpa?: ");
            int input;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Vänligen skriv bara in antalet du vill köpa som en siffra");
                input = int.Parse(Console.ReadLine());

            }
            int sum = input * apple;
            Console.WriteLine($"Du har köpt {input}st äpplen som totalt kostar {sum}kr");

        }
        public void Päron()
        {
            int pear = 26;
            Console.Write("Ett päron kostar 26kr, hur många vill du köpa?: ");
            int input;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Vänligen skriv bara in antalet du vill köpa som en siffra");
                input = int.Parse(Console.ReadLine());

            }
            int sum = input * pear;
            Console.WriteLine($"Du har köpt {input}st päron som totalt kostar {sum}kr");
        }
        public void EndStore()
        {
            Console.WriteLine("Vill du handla mer eller gå tillbaka?");
            Console.WriteLine("4. För att Handla mer");
            Console.WriteLine("0. För att gå tillbaka");
        }
    }
}
