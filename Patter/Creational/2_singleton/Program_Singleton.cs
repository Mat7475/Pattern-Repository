using System;

namespace Patter.Creational.Singleton
{
    public class Program_Singleton
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Singleton - Instance Unique ===\n");

            Console.WriteLine("Récupération de la première instance du vendeur...");
            Vendeur vendeur1 = Vendeur.Instance();
            vendeur1.Nom = "Jean Dupont";
            vendeur1.Adresse = "123 Rue de Paris, 75001 Paris";
            vendeur1.Email = "jean.dupont@auto.fr";

            Console.WriteLine("\nAffichage depuis vendeur1:");
            vendeur1.Affiche();

            Console.WriteLine("\n--- Test de l'unicité de l'instance ---");
            Console.WriteLine("Récupération d'une 'nouvelle' instance...");
            Vendeur vendeur2 = Vendeur.Instance();

            Console.WriteLine("\nAffichage depuis vendeur2 (sans modification):");
            vendeur2.Affiche();

            Console.WriteLine("\n--- Vérification de l'unicité ---");
            Console.WriteLine($"vendeur1 == vendeur2 : {vendeur1 == vendeur2}");
            Console.WriteLine($"Même référence : {Object.ReferenceEquals(vendeur1, vendeur2)}");

            Console.WriteLine("\n--- Modification via vendeur2 ---");
            vendeur2.Nom = "Marie Martin";
            vendeur2.Adresse = "456 Avenue des Champs, 69000 Lyon";
            vendeur2.Email = "marie.martin@auto.fr";

            Console.WriteLine("\nAffichage depuis vendeur1 (montre le changement):");
            vendeur1.Affiche();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}