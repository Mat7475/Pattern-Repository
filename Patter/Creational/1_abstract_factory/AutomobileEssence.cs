using System;

namespace Patter.Creational.AbstractFactory
{
    public class AutomobileEssence : Automobile
    {
        public AutomobileEssence(string modele, string couleur, int puissance, double espace)
          : base(modele, couleur, puissance, espace)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Automobile Essence");
            Console.WriteLine($"  Modèle: {modele}");
            Console.WriteLine($"  Couleur: {couleur}");
            Console.WriteLine($"  Puissance: {puissance} CV");
            Console.WriteLine($"  Espace coffre: {espace} L");
        }
    }
}