using System;

namespace AppConsoleLivres
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }

        public Livre(string titre, string auteur, int anneePublication)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, Année de Publication : {AnneePublication}");
        }
    }
}
