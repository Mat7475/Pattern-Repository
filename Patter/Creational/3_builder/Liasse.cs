using System;
using System.Collections.Generic;

namespace Patter.Creational.Builder
{
    public abstract class Liasse
    {
        protected IList<string> contenu = new List<string>();

        public abstract void AjouteDocument(string document);
        public abstract void Imprime();
    }
}