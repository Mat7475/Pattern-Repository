using Patter.Structural.Bridge;
using System;


namespace Patter.Structural.Bridge
{
    public class Utilisateur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pattern Bridge - Formulaires d'immatriculation ===\n");

            // Formulaire Luxembourg avec implémentation HTML
            Console.WriteLine("--- Formulaire Luxembourg (HTML) ---");
            FormImmatriculationLuxembourg formulaire1 = new
                FormImmatriculationLuxembourg(new FormHtmlImpl());
            formulaire1.affiche();
            if (formulaire1.gereSaisie())
                formulaire1.genereDocument();

            Console.WriteLine();

            // Formulaire France avec implémentation Applet
            Console.WriteLine("--- Formulaire France (Applet) ---");
            FormImmatriculationFrance formulaire2 = new
                FormImmatriculationFrance(new FormAppletImpl());
            formulaire2.affiche();
            if (formulaire2.gereSaisie())
                formulaire2.genereDocument();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}
