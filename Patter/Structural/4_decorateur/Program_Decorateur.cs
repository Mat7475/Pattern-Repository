using System;

namespace Patter.Structural.Decorateur
{
    public class Program_Decorateur
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Decorator - Décoration de Véhicules ===\n");

            Console.WriteLine("--- Vue simple du véhicule ---");
            VueVehicule vueSimple = new VueVehicule();
            vueSimple.Affiche();

            Console.WriteLine("\n--- Vue catalogue complète (modèle + marque) ---");
            VueVehicule vueCatalogue = new VueVehicule();
            ModeleDecorateur modeleDecorateur = new ModeleDecorateur(vueCatalogue);
            MarqueDecorateur marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
            marqueDecorateur.Affiche();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}