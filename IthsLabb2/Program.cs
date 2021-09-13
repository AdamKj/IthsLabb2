using System;

namespace IthsLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Första menyn när man startar applikationen
            Console.WriteLine("Hejsan och välkommen till butiken! Vänligen välj nedan vad du vill göra:");
            DrawBoxMeny1();
            string menyOneInput = Console.ReadLine();

            while (menyOneInput != "0")
            {
                switch (menyOneInput)
                {
                    //Registrera ny kund
                    case "1":
                        Console.Clear();
                        NewCustomer newCustomer = new NewCustomer();
                        Console.Write("Vänligen registrera ett användarnamn: ");
                        string usernameInput = Console.ReadLine();
                        newCustomer.Name = usernameInput;
                        Console.Clear();
                        Console.Write("Välj nu ditt lösenord: ");
                        string passwordInput = Console.ReadLine();
                        //newCustomer.Password = passwordInput;
                        Console.WriteLine("Din profil är nu skapad!");
                        break;
                    //Logga in kund    
                    case "2":
                        Console.Clear();
                        Console.Write("Vänligen skriv in ditt användarnamn: ");

                        Console.Write("Skriv in ditt lösenord: ");
                        break;
                    //Avsluta programmet
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        menyOneInput = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Hejdå!");
            



            Console.ReadKey();

        }

        /// <summary>
        /// Gjorde en Drawbox istället för att skriva ut varje enskild rad, tyckte det blev lite snyggare.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void DrawBoxMeny1(int width = 26, int height = 3)
        {
            Console.WriteLine("");

            //Skapar raden
            string line = new('#', width);

            //Skapar inre raderna
            string innerLine = "Tryck 1 för att Registrera";
            string innerLine1 = "Tryck 2 för att Logga in";
            string innerLine2 = "Tryck 0 för att Avsluta";

            //innerLine += "#";

            //Loopar igenom bredden
            for (int j = 0; j < width - 2; j++)
            {
                innerLine += "";
                innerLine1 += "";
                innerLine2 += "";

            }
            Console.WriteLine(line);

            //Loopar igenom höjden
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(innerLine);
                Console.WriteLine(innerLine1);
                Console.WriteLine(innerLine2);

            }
            Console.WriteLine(line);
        }
    }
}
