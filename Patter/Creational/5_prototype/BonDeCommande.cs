using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Creational.Prototype
{
    public class BonDeCommande : Document
    {
        private string contenu;

        public override Document Duplique()
        {
            return (Document)this.MemberwiseClone();
        }

        public override void Imprime()
        {
            Console.WriteLine("Impression du bon de commande");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Bon de commande : {contenu}");
        }

        public override void Remplit(string informations)
        {
            contenu = informations;
        }
    }
}

