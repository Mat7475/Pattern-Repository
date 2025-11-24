using System;

namespace Patter.Creational.AbstractFactory
{
    public class FabriqueVehiculeElectricite : FabriqueVehicule
    {
        public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectricite(modele, couleur, puissance, espace);
        }

        public Scooter CreeScooter(string modele, string couleur, int puissance)
        {
            return new ScooterElectricite(modele, couleur, puissance);
        }
    }
}