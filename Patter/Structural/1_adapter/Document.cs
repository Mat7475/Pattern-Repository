using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Adapter
{
    public abstract class Document
    {
        public string contenu;

        public abstract void setContenu(string contenu);
        public abstract void dessine();
        public abstract void imprime();
    }
}
