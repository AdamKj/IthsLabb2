using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class DrawBoxes
    {
        /// <summary>
        /// Meny när man startar applikationen
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void DrawBoxMeny1(int width = 30, int height = 3)
        {
            Console.WriteLine("Hejsan och välkommen!");
            Console.WriteLine("Om du är medlem skriv in '2'.");
            Console.WriteLine("Om du inte är medlem, vänligen skriv in '1' för att skapa din profil!");
            Console.WriteLine("");

            //Skapar raden
            string line = new('#', width);

            //Skapar inre raderna
            string innerLine = "Tryck 1 för att Registrera dig";
            string innerLine1 = "Tryck 2 för att Logga in";
            string innerLine2 = "Tryck 0 för att Avsluta";

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

        public void StoreDrawBox(int width = 25, int height = 4)
        {
            Console.Clear();
            Console.WriteLine("Välkommen till butiken! Välj nedan vad du vill handla eller om du vill gå till kundvagnen");
            Console.WriteLine("");

            //Skapar raden
            string line = new('#', width);

            //Skapar inre raderna
            string innerLine = "Tryck 1 för att köpa ";
            string innerLine1 = "Tryck 2 för att köpa ";
            string innerLine2 = "Tryck 3 för att köpa ";
            string innerLine3 = "Tryck 0 för att gå till Kundvagnen";

            //Loopar igenom bredden
            for (int j = 0; j < width - 2; j++)
            {
                innerLine += "";
                innerLine1 += "";
                innerLine2 += "";
                innerLine3 += "";

            }
            Console.WriteLine(line);

            //Loopar igenom höjden
            for (int i = 0; i < height - 3; i++)
            {
                Console.WriteLine(innerLine);
                Console.WriteLine(innerLine1);
                Console.WriteLine(innerLine2);
                Console.WriteLine(innerLine3);
            }
            Console.WriteLine(line);
        }
    }
    
}
