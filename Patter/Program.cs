using System;

namespace Patter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();
                Console.Clear();

                switch (choix)
                {
                    case "1":
                        Creational.AbstractFactory.Program_AbstractFactory.Execute();
                        break;
                    case "2":
                        Creational.Singleton.Program_Singleton.Execute();
                        break;
                    case "3":
                        Creational.Builder.ClientVehicule.Execute();
                        break;
                    case "4":
                        Creational.FactoryMethod.Program_FactoryMethod.Execute();
                        break;
                    case "5":
                        Creational.Prototype.Program_Prototype.Execute();
                        break;
                    case "6":
                        Console.WriteLine("Pattern Adapter - Voir le fichier code.cs complet");
                        break;
                    case "7":
                        Console.WriteLine("Pattern Bridge - Voir le fichier code.cs complet");
                        break;
                    case "8":
                        Structural.Composite.Program_Composite.Execute();
                        break;
                    case "9":
                        Structural.Decorateur.Program_Decorateur.Execute();
                        break;
                    case "0":
                        continuer = false;
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Appuyez sur une touche...");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }

                if (continuer)
                {
                    Console.WriteLine("\n\n▶ Appuyez sur une touche pour revenir au menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║       DESIGN PATTERNS EN C# - MENU PRINCIPAL         ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("┌─────────────────────────────────────────────────────┐");
            Console.WriteLine("│          CREATIONAL PATTERNS (Création)             │");
            Console.WriteLine("├─────────────────────────────────────────────────────┤");
            Console.WriteLine("│ 1. Abstract Factory - Fabrique de véhicules        │");
            Console.WriteLine("│ 2. Singleton - Instance unique du vendeur          │");
            Console.WriteLine("│ 3. Builder - Construction de liasses               │");
            Console.WriteLine("│ 4. Factory Method - Gestion des commandes          │");
            Console.WriteLine("│ 5. Prototype - Clonage de documents                │");
            Console.WriteLine("└─────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.WriteLine("┌─────────────────────────────────────────────────────┐");
            Console.WriteLine("│          STRUCTURAL PATTERNS (Structure)            │");
            Console.WriteLine("├─────────────────────────────────────────────────────┤");
            Console.WriteLine("│ 6. Adapter - Documents HTML/PDF                    │");
            Console.WriteLine("│ 7. Bridge - Formulaires d'immatriculation          │");
            Console.WriteLine("│ 8. Composite - Composants graphiques               │");
            Console.WriteLine("│ 9. Decorator - Décoration de véhicules             │");
            Console.WriteLine("└─────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.WriteLine("┌─────────────────────────────────────────────────────┐");
            Console.WriteLine("│ 0. Quitter                                          │");
            Console.WriteLine("└─────────────────────────────────────────────────────┘");
            Console.WriteLine();
            Console.Write("➤ Votre choix : ");
        }
    }
}