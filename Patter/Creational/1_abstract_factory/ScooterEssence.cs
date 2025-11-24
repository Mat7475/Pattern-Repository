using System;

namespace Patter.Creational.AbstractFactory
{
    public class ScooterEssence : Scooter
    {
        public ScooterEssence(string modele, string couleur, int puissance)
          : base(modele, couleur, puissance)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Scooter Essence");
            Console.WriteLine($"  Modèle: {modele}");
            Console.WriteLine($"  Couleur: {couleur}");
            Console.WriteLine($"  Puissance: {puissance} cm³");
        }
    }
}