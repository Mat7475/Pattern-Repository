using System;

namespace Patter.Structural.Decorateur
{
    public class MarqueDecorateur : Decorateur
    {
        public MarqueDecorateur(ComposantGraphiqueVehicule composant)
          : base(composant)
        {
        }

        protected void AfficheLogo()
        {
            Console.WriteLine("Logo de la marque");
        }

        public override void Affiche()
        {
            base.Affiche();
            this.AfficheLogo();
        }
    }
}