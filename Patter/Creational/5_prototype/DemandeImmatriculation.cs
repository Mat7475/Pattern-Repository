using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Creational.Prototype
{
    public class DemandeImmatriculation : Document
    {
        private string contenu;

        public override Document Duplique()
        {
            return (Document)this.MemberwiseClone();
        }

        public override void Imprime()
        {
            Console.WriteLine("Impression de la demande d'immatriculation");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Demande d'immatriculation : {contenu}");
        }

        public override void Remplit(string informations)
        {
            contenu = informations;
        }
    }
}
