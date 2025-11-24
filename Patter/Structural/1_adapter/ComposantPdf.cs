using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Adapter
{
    public abstract class ComposantPdf
    {
        public abstract void pdfFixeContenu(string contenu);
        public abstract void pdfPrepareAffichage();
        public abstract void pdfRafraichit();
        public abstract void pdfTermineAffichage();
        public abstract void pdfEnvoieImprimante();
    }
}
