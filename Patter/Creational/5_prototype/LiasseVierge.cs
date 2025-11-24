using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Creational.Prototype
{
    public class LiasseVierge : Liasse
    {
        private static LiasseVierge instance;

        private LiasseVierge()
        {
            documents = new List<Document>();
        }

        public static LiasseVierge Instance()
        {
            if (instance == null)
            {
                instance = new LiasseVierge();
            }
            return instance;
        }

        public void ajoute(Document doc)
        {
            documents.Add(doc);
        }

        public void retire(Document doc)
        {
            documents.Remove(doc);
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
