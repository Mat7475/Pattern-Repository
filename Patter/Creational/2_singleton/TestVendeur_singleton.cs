public class TestVendeur
{  static void Main(string[] args)
  {
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.nom = "Vendeur Auto";
    leVendeur.adresse = "Paris";
    leVendeur.email = "vendeur@vendeur.com";
    affiche();
  }
  public static void affiche()
  {
    Vendeur leVendeur = Vendeur.Instance();
    leVendeur.affiche();
  }
}

using System;

public class Vendeur
{    public string nom { get; set; }

    private static Vendeur _instance = null;

    private Vendeur() { }

    public static Vendeur Instance()
    {
        if (_instance == null)
            _instance = new Vendeur();
        return _instance;
    }

    public void affiche()
    {
        Console.WriteLine("Nom : " + nom);
    }
}
