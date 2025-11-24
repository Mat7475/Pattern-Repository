using System;

namespace Patter.Creational.AbstractFactory
{
    public class AutomobileElectricite : Automobile
    {
        public AutomobileElectricite(string modele, string couleur, int puissance, double espace)
          : base(modele, couleur, puissance, espace)
        {
        }

        public override void AfficheCaracteristiques()
        {
            Console.WriteLine("Automobile Électrique");
            Console.WriteLine($"  Modèle: {modele}");
            Console.WriteLine($"  Couleur: {couleur}");
            Console.WriteLine($"  Puissance: {puissance} kW");
            Console.WriteLine($"  Autonomie: {espace} km");
        }
    }
}