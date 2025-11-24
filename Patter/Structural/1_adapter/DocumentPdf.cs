using Patter.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Adapter
{
    public class DocumentPdf : Document
    {
        private ComposantPdf outilPdf;

        public DocumentPdf()
        {
            outilPdf = new OutilPdf();
        }

        public override void setContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public override void dessine()
        {
            outilPdf.pdfFixeContenu(contenu);
            outilPdf.pdfPrepareAffichage();
            outilPdf.pdfRafraichit();
            outilPdf.pdfTermineAffichage();
        }

        public override void imprime()
        {
            outilPdf.pdfFixeContenu(contenu);
            outilPdf.pdfEnvoieImprimante();
        }
    }
}
