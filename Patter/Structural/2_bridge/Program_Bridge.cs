using System;

namespace Patter.Structural.Bridge
{
    public class Program_Bridge
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Bridge - Formulaires d'Immatriculation ===\n");

            Console.WriteLine("--- Formulaire France avec HTML ---");
            FormulaireImpl implHtml = new FormHtmlImpl();
            FormulaireImmatriculation formFranceHtml = new FormImmatriculationFrance(implHtml);
            formFranceHtml.affiche();
            Console.WriteLine();

            Console.WriteLine("\n--- Formulaire Luxembourg avec HTML ---");
            FormulaireImmatriculation formLuxembourgHtml = new FormImmatriculationLuxembourg(implHtml);
            formLuxembourgHtml.affiche();
            Console.WriteLine();

            Console.WriteLine("\n--- Formulaire France avec Applet ---");
            FormulaireImpl implApplet = new FormAppletImpl();
            FormulaireImmatriculation formFranceApplet = new FormImmatriculationFrance(implApplet);
            formFranceApplet.affiche();
            Console.WriteLine();

            Console.WriteLine("\n--- Formulaire Luxembourg avec Applet ---");
            FormulaireImmatriculation formLuxembourgApplet = new FormImmatriculationLuxembourg(implApplet);
            formLuxembourgApplet.affiche();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}