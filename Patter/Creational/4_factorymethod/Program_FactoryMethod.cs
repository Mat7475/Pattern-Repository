using System;

namespace Patter.Creational.FactoryMethod
{
    public class Program_FactoryMethod
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Factory Method - Gestion des Commandes ===\n");

            Console.WriteLine("--- Client Comptant ---");
            Client clientComptant = new ClientComptant();

            Console.WriteLine("\nCommande 1: 2000€");
            clientComptant.NouvelleCommande(2000.0);

            Console.WriteLine("\nCommande 2: 10000€");
            clientComptant.NouvelleCommande(10000.0);

            Console.WriteLine("\n\n--- Client Crédit ---");
            Client clientCredit = new ClientCredit();

            Console.WriteLine("\nCommande 1: 2000€");
            clientCredit.NouvelleCommande(2000.0);

            Console.WriteLine("\nCommande 2: 10000€");
            clientCredit.NouvelleCommande(10000.0);

            Console.WriteLine("\nCommande 3: 4500€");
            clientCredit.NouvelleCommande(4500.0);

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}