using System.Collections.Generic;

namespace Patter.Creational.FactoryMethod
{
    public abstract class Client
    {
        protected IList<Commande> commandes = new List<Commande>();

        protected abstract Commande CreeCommande(double montant);

        public void NouvelleCommande(double montant)
        {
            Commande commande = this.CreeCommande(montant);
            if (commande.Valide())
            {
                commande.Paye();
                commandes.Add(commande);
            }
        }
    }
}