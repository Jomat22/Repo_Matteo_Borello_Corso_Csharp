
public class Auto : IVeicolo
{
    public void Avvia()
    {
        Console.WriteLine("Avvio dell'auto");
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
        Console.WriteLine("Avvio della moto");
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
        Console.WriteLine("Avvio del camion");
    }

    public void MostraTipo()
    {
        Console.WriteLine("Tipo: Camion");
    }
}
public class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        string scelta = tipo.ToLower();

        if (scelta == "auto")
        {
            return new Auto();
        }
        else if (scelta == "moto")
        {
            return new Moto();
        }
        else if (scelta == "camion")
        {
            return new Camion();
        }
        else
        {
            Console.WriteLine("Errore: Tipo di veicolo non riconosciuto.");
            return null;
        }
    }
}