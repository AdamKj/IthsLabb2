﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Store
    {
        public static List<Customer> existingCustomer = new() { new Customer("Knatte", "123"), new Customer("Fnatte", "321"), new Customer("Tjatte", "213") };
        

        public void Products()
        {
            string apple = "Äpple";
            string banana = "Banan";
            string pear = "Päron";
            Products products = new(apple, pear, banana);
            
            Console.Clear();
            Console.WriteLine("Välkommen till våra varor! Välj nedan vad du vill köpa");
            Console.WriteLine("");

            Console.WriteLine($"1. {products.Banana}");
            Console.WriteLine($"2. {products.Apple}");
            Console.WriteLine($"3. {products.Pear}");
            Console.WriteLine("Tryck på 0 för att gå till kundvagnen");

            string input = Console.ReadLine();

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
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        input = Console.ReadLine();
                        break;
                }
            }
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
            Console.WriteLine("0. För att gå till kundvagnen");
        }
    }
}
