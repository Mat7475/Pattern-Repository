using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Bridge
{
    public abstract class FormulaireImpl
    {
        public abstract void dessineTexte(string texte);
        public abstract string gereZoneSaisie();
    }
}
