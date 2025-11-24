using System;
using System.Collections.Generic;

// Classe abstraite Document
public abstract class Document
{
    public abstract Document duplique();
    public abstract void imprime();
    public abstract void affiche();
    public abstract void remplit(string informations);
}

// Classe BonDeCommande
public class BonDeCommande : Document
{
    private string contenu;

    public override Document duplique()
    {
        return (Document)this.MemberwiseClone();
    }

    public override void imprime()
    {
        Console.WriteLine("Impression du bon de commande");
    }

    public override void affiche()
    {
        Console.WriteLine($"Bon de commande : {contenu}");
    }

    public override void remplit(string informations)
    {
        contenu = informations;
    }
}

// Classe CertificatCession
public class CertificatCession : Document
{
    private string contenu;

    public override Document duplique()
    {
        return (Document)this.MemberwiseClone();
    }

    public override void imprime()
    {
        Console.WriteLine("Impression du certificat de cession");
    }

    public override void affiche()
    {
        Console.WriteLine($"Certificat de cession : {contenu}");
    }

    public override void remplit(string informations)
    {
        contenu = informations;
    }
}

// Classe DemandeImmatriculation
public class DemandeImmatriculation : Document
{
    private string contenu;

    public override Document duplique()
    {
        return (Document)this.MemberwiseClone();
    }

    public override void imprime()
    {
        Console.WriteLine("Impression de la demande d'immatriculation");
    }

    public override void affiche()
    {
        Console.WriteLine($"Demande d'immatriculation : {contenu}");
    }

    public override void remplit(string informations)
    {
        contenu = informations;
    }
}

// Classe abstraite Liasse
public abstract class Liasse
{
    public IList<Document> documents;

    public abstract IList<Document> getDocuments();
    public abstract void setDocuments(IList<Document> documents);
}

// Classe LiasseVierge (Singleton)
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

// Classe LiasseClient
public class LiasseClient : Liasse
{
    public LiasseClient(string informations)
    {
        documents = new List<Document>();
        LiasseVierge laLiasseVierge = LiasseVierge.Instance();
        IList<Document> documentsVierges = laLiasseVierge.documents;
        
        foreach (Document document in documentsVierges)
        {
            Document copieDocument = document.duplique();
            copieDocument.remplit(informations);
            documents.Add(copieDocument);
        }
    }

    public void affiche()
    {
        foreach (Document document in documents)
            document.affiche();
    }

    public void imprime()
    {
        foreach (Document document in documents)
            document.imprime();
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

// Programme principal
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pattern Prototype - Gestion de liasses de documents ===\n");

        // Création de la liasse vierge (Singleton)
        LiasseVierge liasseVierge = LiasseVierge.Instance();
        liasseVierge.ajoute(new BonDeCommande());
        liasseVierge.ajoute(new CertificatCession());
        liasseVierge.ajoute(new DemandeImmatriculation());

        Console.WriteLine("Liasse vierge créée avec 3 documents prototypes.\n");

        // Création de liasses pour deux clients
        Console.WriteLine("--- Client 1 : Martin ---");
        LiasseClient liasseClient1 = new LiasseClient("Martin");
        liasseClient1.affiche();

        Console.WriteLine("\n--- Client 2 : Durant ---");
        LiasseClient liasseClient2 = new LiasseClient("Durant");
        liasseClient2.affiche();

        Console.WriteLine("\n--- Impression des documents du client Martin ---");
        liasseClient1.imprime();

        Console.WriteLine("\nProgramme terminé.");
    }
}