using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Customer
    {
        public string Username { get; private set; }
        private string Password { get; set; }

        private List<Products> _cart;
        public List<Products> cart { get { return _cart; } set { _cart = value; } }

        public List<Products> products = new() { new Products("Banan", 17), new Products("Äpple", 9), new Products("Päron", 26) };

        static List<Customer> exsistingCustomers = new() { new Customer("Knatte", "123"), new Customer("Fnatte", "321"), new Customer("Tjatte", "213") };

        static Customer CurrentCustomer;

        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
            cart = new List<Products>();
        }

        /// <summary>
        /// Metod för att logga in befintlig användare
        /// </summary>
        public void LogIn()
        {
            Console.Clear();
            Console.Write("Hej! Vänligen skriv in ditt användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Skriv nu in ditt lösenord: ");
            string password = Console.ReadLine();

            foreach (var customer in exsistingCustomers)
            {
                if (customer.Username == username)
                {
                    if (customer.Password == password)
                    {
                        Console.WriteLine($"Välkommen {username}!");
                        CurrentCustomer = customer;
                        Console.Write("Tryck på valfri tangent för att fortsätta till butiken:");
                        Console.ReadKey();
                        break;
                    } 
                    else
                    {
                        while (password != customer.Password)
                        {
                            Console.Write("Tyvärr var det fel lösenord. Försök igen: ");
                            password = Console.ReadLine();
                        }
                        Console.WriteLine($"Välkommen {username}!");
                        CurrentCustomer = customer;
                        Console.Write("Tryck på valfri tangent för att fortsätta till butiken:");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Metod för att registrera användare
        /// </summary>
        public void CustomerCreation()
        {
            Console.Clear();
            Console.Write("Vänligen skriv in ett användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Skriv nu in ett lösenord: ");
            string password = Console.ReadLine();

            var customer = new Customer(username, password);
            exsistingCustomers.Add(customer);

            Console.WriteLine($"Välkommen {username}! Din profil är nu skapad!");
            Console.Write("Tryck på valfri tangent för att forsätta till butiken: ");
            Console.ReadKey();
        }

        public void Products()
        {
            string product = "";
            double price = 0;
            Products product1 = new Products(product, price);

            Console.Clear();
            Console.WriteLine("Välkommen till våra varor! Välj nedan vad du vill köpa");
            Console.WriteLine("");

            Console.WriteLine("1. Banan");
            Console.WriteLine("2. Äpple");
            Console.WriteLine("3. Päron");
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
            Console.WriteLine($"Du har lagt till {input}st bananer i kundvagnen");
        }

        public void Äpple()
        {
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
            Console.WriteLine($"Du har lagt till {input}st äpplen i kundvagnen");

        }
        public void Päron()
        {
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
            Console.WriteLine($"Du har lagt till {input}st päron i kundvagnen");
        }

        public void EndStore()
        {
            Console.WriteLine("Vill du handla mer eller gå tillbaka?");
            Console.WriteLine("4. För att Handla mer");
            Console.WriteLine("0. För att gå till kundvagnen");
        }
    }
}
