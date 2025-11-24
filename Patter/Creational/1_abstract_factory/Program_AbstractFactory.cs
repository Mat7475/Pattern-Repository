using System;

namespace Patter.Creational.AbstractFactory
{
    public class Program_AbstractFactory
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Abstract Factory - Fabrique de Véhicules ===\n");

            Console.WriteLine("--- Fabrique Électrique ---");
            FabriqueVehicule fabriqueElec = new FabriqueVehiculeElectricite();

            Automobile autoElec = fabriqueElec.CreeAutomobile("Tesla Model 3", "Blanc", 283, 580);
            autoElec.AfficheCaracteristiques();
            Console.WriteLine();

            Scooter scooterElec = fabriqueElec.CreeScooter("Xiaomi Pro 2", "Noir", 300);
            scooterElec.AfficheCaracteristiques();
            Console.WriteLine();

            Console.WriteLine("--- Fabrique Essence ---");
            FabriqueVehicule fabriqueEss = new FabriqueVehiculeEssence();

            Automobile autoEss = fabriqueEss.CreeAutomobile("Peugeot 208", "Rouge", 130, 311);
            autoEss.AfficheCaracteristiques();
            Console.WriteLine();

            Scooter scooterEss = fabriqueEss.CreeScooter("Yamaha NMAX", "Bleu", 125);
            scooterEss.AfficheCaracteristiques();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}
