using System;

namespace Patter.Structural.Decorateur
{
    public class VueVehicule : ComposantGraphiqueVehicule
    {
        public void Affiche()
        {
            Console.WriteLine("Affichage du véhicule de base");
        }
    }
}