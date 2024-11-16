using System;

namespace AppConsoleLivres
{
    public class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, int anneePublication, string genre)
            : base(titre, auteur, anneePublication)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Genre : {Genre}");
        }
    }
}

