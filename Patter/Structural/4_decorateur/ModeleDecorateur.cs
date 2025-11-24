using System;

namespace Patter.Structural.Decorateur
{
    public class ModeleDecorateur : Decorateur
    {
        public ModeleDecorateur(ComposantGraphiqueVehicule composant)
          : base(composant)
        {
        }

        protected void AfficheModele()
        {
            Console.WriteLine("Modèle: Sport GT 2024");
        }

        public override void Affiche()
        {
            base.Affiche();
            this.AfficheModele();
        }
    }
}