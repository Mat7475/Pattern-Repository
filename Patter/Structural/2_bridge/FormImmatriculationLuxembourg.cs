using Patter.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Bridge
{
    public class FormImmatriculationLuxembourg : FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(FormulaireImpl implantation)
            : base(implantation)
        {
        }

        protected override bool controleSaisie(string plaque)
        {
            // Format luxembourgeois : AA 1234 (plus simple)
            if (plaque == null || plaque.Length < 5)
            {
                implantation.dessineTexte("Format invalide pour une plaque luxembourgeoise !");
                return false;
            }

            // Validation simple
            bool valide = plaque.Length >= 5 && plaque.Contains(" ");

            if (!valide)
            {
                implantation.dessineTexte("Le format doit être : AA 1234");
                return false;
            }

            implantation.dessineTexte("Plaque luxembourgeoise valide !");
            return true;
        }
    }
}
