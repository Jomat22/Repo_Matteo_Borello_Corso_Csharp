using System;


public class Auto : Veicolo
{
    public Auto(string targa) : base(targa) 
    { }

    public override void Ripara()
    {
        Console.WriteLine("Targa: " + Targa + "  Controllo olio, freni e motore dell'auto.");
    }
}


public class Moto : Veicolo
{
    public Moto(string targa) : base(targa) 
    { }

    public override void Ripara()
    {
        Console.WriteLine("Targa: " + Targa + "  Controllo catena, freni e gomme della moto.");
    }
}

public class Camion : Veicolo
{
    public Camion(string targa) : base(targa) 
    { }

    public override void Ripara()
    {
        Console.WriteLine("Targa: " + Targa + "  Controllo sospensioni, freni rinforzati e carico del camion.");
    }
}