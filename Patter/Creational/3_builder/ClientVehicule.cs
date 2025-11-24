using System;

namespace Patter.Creational.Builder
{
    public class ClientVehicule
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Builder - Construction de Liasses ===\n");

            ConstructeurLiasseVehicule constructeur;
            Console.WriteLine("Voulez-vous construire des liasses HTML (1) ou PDF (2) :");
            string choix = Console.ReadLine();

            if (choix == "1")
            {
                constructeur = new ConstructeurLiasseVehiculeHtml();
            }
            else
            {
                constructeur = new ConstructeurLiasseVehiculePdf();
            }

            Vendeur vendeur = new Vendeur(constructeur);
            Liasse liasse = vendeur.Construit("Martin");
            liasse.Imprime();
        }
    }
}