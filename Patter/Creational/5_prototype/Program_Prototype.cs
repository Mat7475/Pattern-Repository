using System;
using System.Collections.Generic;


namespace Patter.Creational.Prototype
{
    public class Program_Prototype
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Prototype - Gestion de liasses de documents ===\n");

            // Création de la liasse vierge (Singleton)
            LiasseVierge liasseVierge = LiasseVierge.Instance();
            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new CertificatCession());
            liasseVierge.ajoute(new DemandeImmatriculation());

            Console.WriteLine("Liasse vierge créée avec 3 documents prototypes.\n");

            // Création de liasses pour deux clients
            Console.WriteLine("--- Client 1 : Martin ---");
            LiasseClient liasseClient1 = new LiasseClient("Martin");
            liasseClient1.affiche();

            Console.WriteLine("\n--- Client 2 : Durant ---");
            LiasseClient liasseClient2 = new LiasseClient("Durant");
            liasseClient2.affiche();

            Console.WriteLine("\n--- Impression des documents du client Martin ---");
            liasseClient1.imprime();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}