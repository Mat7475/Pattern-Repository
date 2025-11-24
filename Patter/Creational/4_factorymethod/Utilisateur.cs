using System;
namespace Patter.Creational.FactoryMethod
{
    public class Utilisateur
    {
        static void Main(string[] args)
        {
            Client client;
            client = new ClientComptant();
            client.NouvelleCommande(2000.0);
            client.NouvelleCommande(10000.0);
            client = new ClientCredit();
            client.NouvelleCommande(2000.0);
            client.NouvelleCommande(10000.0);
        }
    }
}
