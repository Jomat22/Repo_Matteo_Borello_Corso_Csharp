using System;
using System.Collections.Generic;

//Interfaccia
public interface ITorta
{
    string Descrizione();
}

// Classi Derivate
public class TortaCioccolato : ITorta
{
    public string Descrizione() => "Torta al cioccolato";
}

public class TortaVaniglia : ITorta
{
    public string Descrizione() => "Torta alla vaniglia";
}

public class TortaFrutta : ITorta
{
    public string Descrizione() => "Torta alla frutta";
}

// Decoratori


public abstract class DecoratoreTorta : ITorta
{
    protected ITorta baseTorta; 

    public DecoratoreTorta(ITorta torta)
    {
        this.baseTorta = torta;
    }

    public abstract string Descrizione();
}

public class ConPanna : DecoratoreTorta
{
    public ConPanna(ITorta torta) : base(torta) { }
    public override string Descrizione() => baseTorta.Descrizione() + " + panna";
}

public class ConMirtilli : DecoratoreTorta
{
    public ConMirtilli(ITorta torta) : base(torta) { }
    public override string Descrizione() => baseTorta.Descrizione() + " + Mirtilli";
}

public class ConGlassa : DecoratoreTorta
{
    public ConGlassa(ITorta torta) : base(torta) { }
    public override string Descrizione() => baseTorta.Descrizione() + " + glassa";
}

// Factory
public static class TortaFactory
{
    public static ITorta CreaTortaBase(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "cioccolato": return new TortaCioccolato();
            case "vaniglia": return new TortaVaniglia();
            case "frutta": return new TortaFrutta();
            default: return null;
        }
    }
}

//Observer


public interface IOsservatore
{
    void Aggiorna(string msg);
}

public class RepartoLaboratorio : IOsservatore
{
    public void Aggiorna(string msg)
    {
        Console.WriteLine($"\nRiepilogo ordine: {msg}.");
    }
}

// Singleton

public class RegistroOrdini
{
    private static RegistroOrdini _istanza;
    private List<IOsservatore> _osservatori = new List<IOsservatore>();
    private List<string> _storicoOrdini = new List<string>();

    private RegistroOrdini() { }

    public static RegistroOrdini GetIstanza()
    {
        if (_istanza == null)
            _istanza = new RegistroOrdini();
        return _istanza;
    }

    public void Iscrivi(IOsservatore oss) => _osservatori.Add(oss);

    public void Salva(ITorta torta)
    {
        string d = torta.Descrizione();
        _storicoOrdini.Add(d);
        Console.WriteLine("Ordine Salvato nel singleton");
        
        foreach (var o in _osservatori)
            o.Aggiorna(d);
    }
}