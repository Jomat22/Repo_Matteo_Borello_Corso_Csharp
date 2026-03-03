using System;

public class Fante : Soldato
{
    private string arma;

    public string Arma
    {
        get { return arma; }
        set { arma = value; }
    }

    public Fante(string nome, string grado, int anniServizio, string arma) : base(nome, grado, anniServizio)
    {
        this.arma = arma;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($", Arma: {Arma}");
    }
}

public class Artigliere : Soldato
{
    private int calibro;

    public int Calibro
    {
        get { return calibro; }
        set 
        { 
            if (value > 0) calibro = value; 
            else calibro = 1; 
        }
    }

    public Artigliere(string nome, string grado, int anniServizio, int calibro) : base(nome, grado, anniServizio)
    {
        this.calibro = calibro;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($", Arma calibro: {Calibro}mm");
    }
}