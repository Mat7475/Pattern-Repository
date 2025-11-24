using System;
using System.Collections.Generic;

namespace Patter.Structural.Composite
{
    public class GroupeGraphique : ComposantGraphique
    {
        private string nom;
        private List<ComposantGraphique> composants = new List<ComposantGraphique>();

        public GroupeGraphique(string nom)
        {
            this.nom = nom;
        }

        public void Ajoute(ComposantGraphique composant)
        {
            composants.Add(composant);
        }

        public void Retire(ComposantGraphique composant)
        {
            composants.Remove(composant);
        }

        public override void Affiche()
        {
            Console.WriteLine($"Groupe: {nom}");
            foreach (ComposantGraphique composant in composants)
            {
                Console.Write("  ");
                composant.Affiche();
            }
        }

        public override void Dessine()
        {
            Console.WriteLine($"Dessin du groupe '{nom}':");
            foreach (ComposantGraphique composant in composants)
            {
                composant.Dessine();
            }
        }
    }
}
