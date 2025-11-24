using System;

namespace Patter.Creational.FactoryMethod
{
    public class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant)
        {
        }

        public override bool Valide()
        {
            Console.WriteLine($"Validation commande crédit de {montant}€");

            if (montant <= 5000.0)
            {
                Console.WriteLine("  ✓ Commande valide (montant < 5000€)");
                return true;
            }
            else
            {
                Console.WriteLine("  ✗ Commande refusée (montant > 5000€)");
                return false;
            }
        }

        public override void Paye()
        {
            Console.WriteLine($"Paiement crédit de {montant}€ en cours...");
            Console.WriteLine("  - Vérification du dossier de crédit");
            Console.WriteLine("  - Mise en place des mensualités");
        }
    }
}