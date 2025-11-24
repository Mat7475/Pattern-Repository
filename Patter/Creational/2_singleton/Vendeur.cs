using System;

namespace Patter.Creational.Singleton
{
    public class Vendeur
    {
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }

        private static Vendeur _instance = null;

        private Vendeur()
        {
            Console.WriteLine("Construction de l'instance unique du Vendeur");
        }

        public static Vendeur Instance()
        {
            if (_instance == null)
            {
                _instance = new Vendeur();
            }
            return _instance;
        }

        public void Affiche()
        {
            Console.WriteLine($"  Nom: {Nom}");
            Console.WriteLine($"  Adresse: {Adresse}");
            Console.WriteLine($"  Email: {Email}");
        }
    }
}