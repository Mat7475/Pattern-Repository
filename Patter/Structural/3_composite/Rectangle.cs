using System;

namespace Patter.Structural.Composite
{
    public class Rectangle : ComposantGraphique
    {
        private string nom;

        public Rectangle(string nom)
        {
            this.nom = nom;
        }

        public override void Affiche()
        {
            Console.WriteLine($"Rectangle: {nom}");
        }

        public override void Dessine()
        {
            Console.WriteLine($"  Dessin du rectangle '{nom}' ▭");
        }
    }
}