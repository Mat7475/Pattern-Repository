using Patter.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Structural.Bridge
{
    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(FormulaireImpl implantation)
            : base(implantation)
        {
        }

        protected override bool controleSaisie(string plaque)
        {
            // Format français : AA-123-AA (7 caractères avec tirets)
            if (plaque == null || plaque.Length < 7)
            {
                implantation.dessineTexte("Format invalide pour une plaque française !");
                return false;
            }

            // Validation simple du format
            bool valide = plaque.Length >= 7 && plaque.Contains("-");

            if (!valide)
            {
                implantation.dessineTexte("Le format doit être : AA-123-AA");
                return false;
            }

            implantation.dessineTexte("Plaque française valide !");
            return true;
        }
    }
}
