using System;
using System.Collections.Generic;

public class CentroMeteo : ISoggetto
{
    private List<IObserver> _osservatori = new List<IObserver>();
    private string _datiMeteo;

    public string GetDatiMeteo() { return _datiMeteo; }
    public void SetDatiMeteo(string valore) { _datiMeteo = valore; }

    public void Registra(IObserver osservatore)
    {
        _osservatori.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)
    {
        _osservatori.Remove(osservatore);
    }

    public void Notifica(string messaggio)
    {
        foreach (var osservatore in _osservatori)
        {
            osservatore.Aggiorna(messaggio);
        }
    }

    public void AggiornaMeteo(string nuoviDati)
    {
        SetDatiMeteo(nuoviDati);
        Console.WriteLine($"\nAggiornamento meteo: {GetDatiMeteo()}");
        Notifica(GetDatiMeteo());
    }
}

public class DisplayConsole : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento meteo su console: {messaggio}");
    }
}

public class DisplayMobile : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Notifica su mobile: {messaggio}");
    }
}