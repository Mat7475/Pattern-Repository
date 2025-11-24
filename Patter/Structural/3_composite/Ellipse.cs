using System;

namespace Patter.Structural.Composite
{
    public class Ellipse : ComposantGraphique
    {
        private string nom;

        public Ellipse(string nom)
        {
            this.nom = nom;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Ellipse: {nom}");
        }

        public override void Dessine()
        {
            Console.WriteLine($"  Dessin de l'ellipse '{nom}' ○");
        }
    }
}