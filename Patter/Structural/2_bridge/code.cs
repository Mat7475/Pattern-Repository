using System;

// Interface FormulaireImpl (Implementor)
public abstract class FormulaireImpl
{
    public abstract void dessineTexte(string texte);
    public abstract string gereZoneSaisie();
}

// Implémentation HTML
public class FormHtmlImpl : FormulaireImpl
{
    public override void dessineTexte(string texte)
    {
        Console.WriteLine($"[HTML] {texte}");
    }

    public override string gereZoneSaisie()
    {
        Console.Write("[HTML] Entrez la plaque : ");
        string saisie = Console.ReadLine();
        return saisie;
    }
}

// Implémentation Applet
public class FormAppletImpl : FormulaireImpl
{
    public override void dessineTexte(string texte)
    {
        Console.WriteLine($"[APPLET] {texte}");
    }

    public override string gereZoneSaisie()
    {
        Console.Write("[APPLET] Entrez la plaque : ");
        string saisie = Console.ReadLine();
        return saisie;
    }
}

// Classe abstraite FormulaireImmatriculation (Abstraction)
public abstract class FormulaireImmatriculation
{
    protected string contenu;
    protected FormulaireImpl implantation;

    public FormulaireImmatriculation(FormulaireImpl implantation)
    {
        this.implantation = implantation;
    }

    public void affiche()
    {
        implantation.dessineTexte("numéro de la plaque existante : ");
    }

    public void genereDocument()
    {
        implantation.dessineTexte("Demande d'immatriculation");
        implantation.dessineTexte("numéro de plaque : " + contenu);
    }

    public bool gereSaisie()
    {
        contenu = implantation.gereZoneSaisie();
        return this.controleSaisie(contenu);
    }

    protected abstract bool controleSaisie(string plaque);
}

// Formulaire pour la France
public class FormImmatriculationFrance : FormulaireImmatriculation
{
    public FormImmatriculationFrance(FormulaireImpl implantation) 
        : base(implantation)
    {
    }

    protected override bool controleSaisie(string plaque)
    {
        // Format français : AA-123-AA (7 caractères avec tirets)
        if (plaque == null || plaque.Length < 7)
        {
            implantation.dessineTexte("Format invalide pour une plaque française !");
            return false;
        }

        // Validation simple du format
        bool valide = plaque.Length >= 7 && plaque.Contains("-");
        
        if (!valide)
        {
            implantation.dessineTexte("Le format doit être : AA-123-AA");
            return false;
        }

        implantation.dessineTexte("Plaque française valide !");
        return true;
    }
}

// Formulaire pour le Luxembourg
public class FormImmatriculationLuxembourg : FormulaireImmatriculation
{
    public FormImmatriculationLuxembourg(FormulaireImpl implantation) 
        : base(implantation)
    {
    }

    protected override bool controleSaisie(string plaque)
    {
        // Format luxembourgeois : AA 1234 (plus simple)
        if (plaque == null || plaque.Length < 5)
        {
            implantation.dessineTexte("Format invalide pour une plaque luxembourgeoise !");
            return false;
        }

        // Validation simple
        bool valide = plaque.Length >= 5 && plaque.Contains(" ");
        
        if (!valide)
        {
            implantation.dessineTexte("Le format doit être : AA 1234");
            return false;
        }

        implantation.dessineTexte("Plaque luxembourgeoise valide !");
        return true;
    }
}

// Programme principal
public class Utilisateur
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Pattern Bridge - Formulaires d'immatriculation ===\n");

        // Formulaire Luxembourg avec implémentation HTML
        Console.WriteLine("--- Formulaire Luxembourg (HTML) ---");
        FormImmatriculationLuxembourg formulaire1 = new
            FormImmatriculationLuxembourg(new FormHtmlImpl());
        formulaire1.affiche();
        if (formulaire1.gereSaisie())
            formulaire1.genereDocument();

        Console.WriteLine();

        // Formulaire France avec implémentation Applet
        Console.WriteLine("--- Formulaire France (Applet) ---");
        FormImmatriculationFrance formulaire2 = new
            FormImmatriculationFrance(new FormAppletImpl());
        formulaire2.affiche();
        if (formulaire2.gereSaisie())
            formulaire2.genereDocument();

        Console.WriteLine("\nProgramme terminé.");
    }
}