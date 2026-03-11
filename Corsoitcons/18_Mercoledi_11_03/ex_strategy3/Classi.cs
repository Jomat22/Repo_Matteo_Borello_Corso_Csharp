using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
//Classi concrete per il prodotto
public class Pizza : IPiatto
{
    public string Descrizione()
    {
        return "Pizza";
    }
}
public class Hamburger : IPiatto
{
    public string Descrizione()
    {
        return "Hamburger";
    }
}
public class Insalata : IPiatto
{
    public string Descrizione()
    {
        return "Insalata";
    }
}

//Classe factory method
public static class PiattoFactory
{
    public static IPiatto? Crea(string? tipo)
    {
        if (string.IsNullOrEmpty(tipo)) return null;
        switch (tipo.ToLower())
        {
            case "pizza": return new Pizza();
            case "1": return new Pizza();
            case "hamburger": return new Hamburger();
            case "2": return new Hamburger();
            case "insalata": return new Insalata();
            case "3": return new Insalata();
            default: return null;
        }
    }
}

//Classi decoratori
public abstract class IngredienteExtra : IPiatto
{
    protected IPiatto _piatto;
    public IngredienteExtra (IPiatto piatto)
    {
        _piatto = piatto;
    }
    public abstract string Descrizione();
}

public class ConFormaggio : IngredienteExtra
{
    public ConFormaggio(IPiatto p) : base(p){}
    public override string Descrizione() {return _piatto.Descrizione() + " + Formaggio";}
}
public class ConBacon : IngredienteExtra
{
    public ConBacon(IPiatto p) : base(p){}
    public override string Descrizione() {return _piatto.Descrizione() + " + Bacon";}
}
public class ConSalsa : IngredienteExtra
{
    public ConSalsa(IPiatto p) : base(p){}
    public override string Descrizione() {return _piatto.Descrizione() + " + Salsa";}
}

//Classi strategy (modo preparazione)
public class Fritto : IPreparazioneStrategia
{
    public string Prepara(string nome)
    {
        return $"Preparando: {nome} nella friggitrice";
    }
}
public class AlForno : IPreparazioneStrategia
{
    public string Prepara(string nome)
    {
        return $"Preparando: {nome} al forno";
    }
}
public class AllaGriglia : IPreparazioneStrategia
{
    public string Prepara(string nome)
    {
        return $"Preparando: {nome} alla griglia";
    }
}

//Classi per il singleton e observer
public class Chef : ISubject
{
    private static Chef? _instance;
    private IPreparazioneStrategia? _strategia;
    private List<IObserver> _clienti = new List<IObserver>();

//Costruttore per il singleton
    private Chef(){}

    public static Chef GetInstance()
    {
        if (_instance == null) _instance = new Chef();
        return _instance;
    }
    public void SetStrategia(IPreparazioneStrategia strategia)
    {
        this._strategia = strategia;
    }

    public void PreparaPiatto(IPiatto piatto)
    {
        if (_strategia == null)
        {
            Console.WriteLine();
            return;
        }
        string risultato = _strategia.Prepara(piatto.Descrizione());
        Console.WriteLine(risultato);
        Notifica("Il seguente ordine è pronto: "+ piatto.Descrizione());
    }

    public void Registra(IObserver o)
    {
        _clienti.Add(o);
    }
    public void Notifica(string mex)
    {
        foreach (var c in _clienti) c.Aggiorna(mex);
    }
}

//Observer Derivato
public class Cliente : IObserver
{
    private string _nome;
    public Cliente(string nome)
    {
        _nome = nome;
    }
    public void Aggiorna(string mex)
    {
        Console.WriteLine($"Questa notifica è per {_nome} : {mex}");
    }
}