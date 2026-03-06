using System;

public class Mucca : Animale
{
    private int _quantitaLatte;
    public int quantitaLatte
    {
        get { return _quantitaLatte;}
        set { _quantitaLatte = value;}
    }

    public Mucca(string nome, int eta, int litri) : base(nome, eta)
    {
        _quantitaLatte = litri;
    }

    public override void VersoAnimale()
    {
        Console.WriteLine("La mucca Muggisce");
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($", Quantita Latte: {_quantitaLatte}L");
    }
}

public class Gallina : Animale
{
    private int _uovaGiornaliere;
    public int uovaGiornaliere
    {
        get { return _uovaGiornaliere;}
        set { _uovaGiornaliere = value;}
    }

    public Gallina(string nome, int eta, int uova) : base(nome, eta)
    {
        _uovaGiornaliere = uova;
    }

    public override void VersoAnimale()
    {
        Console.WriteLine("La gallifa fà coccodè");
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($", Uova al giorno: {_uovaGiornaliere}");
    }
}

public class Pecora : Animale
{
    private int _quantitaLana;
    public int quantitaLana
    {
        get { return _quantitaLana;}
        set { _quantitaLana = value;}
    }

    public Pecora(string nome, int eta, int lana) : base(nome, eta)
    {
        _quantitaLana = lana;
    }

    public override void VersoAnimale()
    {
        Console.WriteLine("La pecora Bela");
    }

    public override void MostraInfo(){
        base.MostraInfo();
        Console.WriteLine($"Quantita lana: {_quantitaLana} KG");
    }
}

public class Maiale : Animale
{
    private double _peso;
    public double peso
    {
        get { return _peso;}
        set { _peso = value;}
    }

    public Maiale(string nome, int eta,  double peso) : base(nome, eta)
    {
        _peso = peso;
    }

    public override void VersoAnimale()
    {
        Console.WriteLine("Il maiale Grugnisce");
    }

    public override void MostraInfo()
    {
        base.MostraInfo();
        Console.WriteLine($", Peso: {_peso} KG");
    }
}