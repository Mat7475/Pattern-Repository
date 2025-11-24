using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Bridge
{
    public class FormHtmlImpl : FormulaireImpl
    {
        public override void dessineTexte(string texte)
        {
            Console.WriteLine($"[HTML] {texte}");
        }

        public override string gereZoneSaisie()
        {
            Console.Write("[HTML] Entrez la plaque : ");
            string saisie = Console.ReadLine();
            return saisie;
        }
    }
}
