using System;

namespace Patter.Creational.FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant)
        {
        }

        public override bool Valide()
        {
            Console.WriteLine($"Validation commande comptant de {montant}€");
            Console.WriteLine("  ✓ Commande valide (paiement comptant)");
            return true;
        }

        public override void Paye()
        {
            Console.WriteLine($"Paiement comptant de {montant}€ effectué");
        }
    }
}