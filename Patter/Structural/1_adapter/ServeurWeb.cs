using System;


namespace Patter.Structural.Adapter
{
    public class ServeurWeb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Pattern Composite - Serveur Web ===\n");

            // Document HTML
            Document document1;
            document1 = new DocumentHtml();
            document1.contenu = "Hello";
            Console.WriteLine("--- Document HTML ---");
            document1.dessine();

            Console.WriteLine();

            // Document PDF
            Document document2;
            document2 = new DocumentPdf();
            document2.contenu = "Bonjour";
            Console.WriteLine("--- Document PDF ---");
            document2.dessine();

            Console.WriteLine("\n--- Test d'impression PDF ---");
            document2.imprime();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}
