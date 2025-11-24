using System;

namespace Patter.Creational.AbstractFactory
{
    public class ScooterElectricite : Scooter
    {
        public ScooterElectricite(string modele, string couleur, int puissance)
          : base(modele, couleur, puissance)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter Électrique");
            Console.WriteLine($"  Modèle: {modele}");
            Console.WriteLine($"  Couleur: {couleur}");
            Console.WriteLine($"  Puissance: {puissance} W");
        }
    }
}