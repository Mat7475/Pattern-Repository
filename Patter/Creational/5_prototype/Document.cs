using System;

namespace Patter.Creational.Prototype
{
    public abstract class Document
    {
        public abstract Document Duplique();
        public abstract void Imprime();
        public abstract void Affiche();
        public abstract void Remplit(string informations);
    }
}