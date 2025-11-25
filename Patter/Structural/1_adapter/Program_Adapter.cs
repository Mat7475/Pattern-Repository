using System;

namespace Patter.Structural.Adapter
{
    public class Program_Adapter
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Adapter - Documents HTML et PDF ===\n");

            Console.WriteLine("--- Document HTML ---");
            Document docHtml = new DocumentHtml();
            docHtml.setContenu("Contrat de vente véhicule");
            Console.WriteLine("\nAffichage du document HTML:");
            docHtml.dessine();
            Console.WriteLine("\nImpression du document HTML:");
            docHtml.imprime();

            Console.WriteLine("\n\n--- Document PDF (via Adaptateur) ---");
            Document docPdf = new DocumentPdf();
            docPdf.setContenu("Certificat d'immatriculation");
            Console.WriteLine("\nAffichage du document PDF:");
            docPdf.dessine();
            Console.WriteLine("\nImpression du document PDF:");
            docPdf.imprime();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}