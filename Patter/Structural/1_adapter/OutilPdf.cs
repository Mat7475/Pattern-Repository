using Patter.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Adapter
{
    public class OutilPdf : ComposantPdf
    {
        private string contenuPdf;

        public override void pdfFixeContenu(string contenu)
        {
            this.contenuPdf = contenu;
            Console.WriteLine($"PDF: Fixation du contenu '{contenu}'");
        }

        public override void pdfPrepareAffichage()
        {
            Console.WriteLine("PDF: Préparation de l'affichage");
        }

        public override void pdfRafraichit()
        {
            Console.WriteLine($"PDF: Rafraîchissement - affichage de '{contenuPdf}'");
        }

        public override void pdfTermineAffichage()
        {
            Console.WriteLine("PDF: Fin de l'affichage");
        }

        public override void pdfEnvoieImprimante()
        {
            Console.WriteLine($"PDF: Envoi à l'imprimante du contenu '{contenuPdf}'");
        }
    }
}
