using System;

namespace Patter.Creational.AbstractFactory
{
    public interface FabriqueVehicule
    {
        Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace);
        Scooter CreeScooter(string modele, string couleur, int puissance);
    }
}