using System;

namespace Patter.Creational.AbstractFactory
{
    public class FabriqueVehiculeEssence : FabriqueVehicule
    {
        public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileEssence(modele, couleur, puissance, espace);
        }

        public Scooter CreeScooter(string modele, string couleur, int puissance)
        {
            return new ScooterEssence(modele, couleur, puissance);
        }
    }
}