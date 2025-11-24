using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patter.Creational.Prototype
{
    public abstract class Liasse
    {
        public IList<Document> documents;

        public abstract IList<Document> getDocuments();
        public abstract void setDocuments(IList<Document> documents);
    }
}
