using System;
using System.Collections.Generic;

// Classe abstraite Document
public abstract class Document
{
    public string contenu;

    public abstract void setContenu(string contenu);
    public abstract void dessine();
    public abstract void imprime();
}

// Classe DocumentHtml
public class DocumentHtml : Document
{
    public override void setContenu(string contenu)
    {
        this.contenu = contenu;
    }

    public override void dessine()
    {
        Console.WriteLine($"Dessine document HTML : {contenu}");
    }

    public override void imprime()
    {
        Console.WriteLine($"Imprime document HTML : {contenu}");
    }
}

// Classe ComposantPdf
public abstract class ComposantPdf
{
    public abstract void pdfFixeContenu(string contenu);
    public abstract void pdfPrepareAffichage();
    public abstract void pdfRafraichit();
    public abstract void pdfTermineAffichage();
    public abstract void pdfEnvoieImprimante();
}

// Classe DocumentPdf (utilise le Composite)
public class DocumentPdf : Document
{
    private ComposantPdf outilPdf;

    public DocumentPdf()
    {
        outilPdf = new OutilPdf();
    }

    public override void setContenu(string contenu)
    {
        this.contenu = contenu;
    }

    public override void dessine()
    {
        outilPdf.pdfFixeContenu(contenu);
        outilPdf.pdfPrepareAffichage();
        outilPdf.pdfRafraichit();
        outilPdf.pdfTermineAffichage();
    }

    public override void imprime()
    {
        outilPdf.pdfFixeContenu(contenu);
        outilPdf.pdfEnvoieImprimante();
    }
}

// Classe OutilPdf (implémentation concrète de ComposantPdf)
public class OutilPdf : ComposantPdf
{
    private string contenuPdf;

    public override void pdfFixeContenu(string contenu)
    {
        this.contenuPdf = contenu;
        Console.WriteLine($"PDF: Fixation du contenu '{contenu}'");
    }

    public override void pdfPrepareAffichage()
    {
        Console.WriteLine("PDF: Préparation de l'affichage");
    }

    public override void pdfRafraichit()
    {
        Console.WriteLine($"PDF: Rafraîchissement - affichage de '{contenuPdf}'");
    }

    public override void pdfTermineAffichage()
    {
        Console.WriteLine("PDF: Fin de l'affichage");
    }

    public override void pdfEnvoieImprimante()
    {
        Console.WriteLine($"PDF: Envoi à l'imprimante du contenu '{contenuPdf}'");
    }
}

// Programme principal (ServeurWeb)
public class ServeurWeb
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pattern Composite - Serveur Web ===\n");

        // Document HTML
        Document document1;
        document1 = new DocumentHtml();
        document1.contenu = "Hello";
        Console.WriteLine("--- Document HTML ---");
        document1.dessine();

        Console.WriteLine();

        // Document PDF
        Document document2;
        document2 = new DocumentPdf();
        document2.contenu = "Bonjour";
        Console.WriteLine("--- Document PDF ---");
        document2.dessine();

        Console.WriteLine("\n--- Test d'impression PDF ---");
        document2.imprime();

        Console.WriteLine("\nProgramme terminé.");
    }
}