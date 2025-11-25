using Patter.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Bridge
{
    public class FormAppletImpl : FormulaireImpl
    {
        public override void dessineTexte(string texte)
        {
            Console.WriteLine($"[APPLET] {texte}");
        }

        public override string gereZoneSaisie()
        {
            Console.Write("[APPLET] Entrez la plaque : ");
            string saisie = Console.ReadLine();
            return saisie;
        }
    }
}
