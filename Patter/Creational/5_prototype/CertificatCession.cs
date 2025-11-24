using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Creational.Prototype
{
    public class CertificatCession : Document
    {
        private string contenu;

        public override Document Duplique()
        {
            return (Document)this.MemberwiseClone();
        }

        public override void Imprime()
        {
            Console.WriteLine("Impression du certificat de cession");
        }

        public override void Affiche()
        {
            Console.WriteLine($"Certificat de cession : {contenu}");
        }

        public override void Remplit(string informations)
        {
            contenu = informations;
        }
    }
}
