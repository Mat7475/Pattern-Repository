using Patter.Creational.Prototype;
using System;
using System.Collections.Generic;

namespace Patter.Creational.Prototype
{
    public class LiasseClient : Liasse
    {
        public LiasseClient(string informations)
        {
            documents = new List<Document>();
            LiasseVierge laLiasseVierge = LiasseVierge.Instance();
            IList<Document> documentsVierges = laLiasseVierge.documents;

            foreach (Document document in documentsVierges)
            {
                Document copieDocument = document.Duplique();
                copieDocument.Remplit(informations);
                documents.Add(copieDocument);
            }
        }

        public void affiche()
        {
            foreach (Document document in documents)
                document.Affiche();
        }

        public void imprime()
        {
            foreach (Document document in documents)
                document.Imprime();
        }

        public override IList<Document> getDocuments()
        {
            return documents;
        }

        public override void setDocuments(IList<Document> documents)
        {
            this.documents = documents;
        }
    }
}
