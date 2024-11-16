using System;

namespace AppConsoleLivres
{
    public class Revue : Livre
    {
        public int Numero { get; set; }

        public Revue(string titre, string auteur, int anneePublication, int numero)
            : base(titre, auteur, anneePublication)
        {
            Numero = numero;
        }

        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numéro de la Revue : {Numero}");
        }
    }
}
