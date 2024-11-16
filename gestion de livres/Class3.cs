using System;
using System.Collections.Generic;

namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            var revue1 = new Revue("Revue Scientifique", "Jean Dupont", 2021, 101);
            var revue2 = new Revue("Revue Littéraire", "Marie Curie", 2020, 102);
            var revue3 = new Revue("Revue Technologique", "Albert Einstein", 2022, 103);

            var roman1 = new Roman("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1954, "Fantasy");
            var roman2 = new Roman("Harry Potter", "J.K. Rowling", 1997, "Fantasy");
            var roman3 = new Roman("Le Petit Prince", "Antoine de Saint-Exupéry", 1943, "Conte");

            List<Livre> listeLivres = new List<Livre> { revue1, revue2, revue3, roman1, roman2, roman3 };

            foreach (var livre in listeLivres)
            {
                livre.AfficherDetails();
                Console.WriteLine("-------------------------");
            }
        }
    }
}

