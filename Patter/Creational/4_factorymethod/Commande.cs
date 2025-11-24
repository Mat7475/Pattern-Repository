using System;

namespace Patter.Creational.FactoryMethod
{
    public abstract class Commande
    {
        protected double montant;

        public Commande(double montant)
        {
            this.montant = montant;
        }

        public abstract bool Valide();
        public abstract void Paye();
    }
}