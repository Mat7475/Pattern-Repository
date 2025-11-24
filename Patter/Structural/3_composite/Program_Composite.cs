using System;

namespace Patter.Structural.Composite
{
    public class Program_Composite
    {
        public static void Execute()
        {
            Console.WriteLine("=== Pattern Composite - Arbre de Composants Graphiques ===\n");

            Ellipse roue1 = new Ellipse("Roue avant");
            Ellipse roue2 = new Ellipse("Roue arrière");
            Rectangle chassis = new Rectangle("Châssis");
            Rectangle cabine = new Rectangle("Cabine");
            Ellipse volant = new Ellipse("Volant");

            GroupeGraphique voiture = new GroupeGraphique("Voiture");
            voiture.Ajoute(chassis);
            voiture.Ajoute(roue1);
            voiture.Ajoute(roue2);
            voiture.Ajoute(cabine);
            voiture.Ajoute(volant);

            Rectangle route = new Rectangle("Route");
            Ellipse soleil = new Ellipse("Soleil");

            GroupeGraphique scene = new GroupeGraphique("Scène complète");
            scene.Ajoute(route);
            scene.Ajoute(voiture);
            scene.Ajoute(soleil);

            Console.WriteLine("--- Structure de la scène ---");
            scene.Affiche();

            Console.WriteLine("\n--- Dessin de la scène complète ---");
            scene.Dessine();

            Console.WriteLine("\nProgramme terminé.");
        }
    }
}