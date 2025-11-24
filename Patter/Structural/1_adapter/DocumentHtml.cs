using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Adapter
{
    public class DocumentHtml : Document
    {
        public override void setContenu(string contenu)
        {
            this.contenu = contenu;
        }

        public override void dessine()
        {
            Console.WriteLine($"Dessine document HTML : {contenu}");
        }

        public override void imprime()
        {
            Console.WriteLine($"Imprime document HTML : {contenu}");
        }
    }
}
