public class Auto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Aggiunta dell'auto");
    }
    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Auto");
    }
}

public class Moto : IVeicolo
{
    public void Avvia() 
    {
        Console.WriteLine("Aggiunta della moto.");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Moto");
    }
}

public class Camion : IVeicolo
{
    public void Avvia() 
    { 
        Console.WriteLine("Aggiunta del camion.");
    }
    public void MostraTipo()
    { 
        Console.WriteLine("Tipo: Camion");
    }
}