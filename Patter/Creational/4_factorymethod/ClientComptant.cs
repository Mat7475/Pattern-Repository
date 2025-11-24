namespace Patter.Creational.FactoryMethod
{
    public class ClientComptant : Client
    {
        protected override Commande CreeCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}