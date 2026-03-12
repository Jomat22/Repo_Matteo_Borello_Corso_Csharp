using System;
using System.Collections.Generic;


class Monitor : IObserver
{
    public void Accendi() => Console.WriteLine("Accensione schermo");
    public void Spegni() => Console.WriteLine("Spegnimento schermo");

    public void Aggiorna(string messaggio) => Console.WriteLine($"Notifica per il monitor: {messaggio}");
}

class Tastiera
{
    public void Attiva() => Console.WriteLine("Attivazione tastiera.");
    public void Disattiva() => Console.WriteLine("Disattivazione tastiera.");
}

class Mouse
{
    public void Attiva() => Console.WriteLine("Attivazione mouse.");
    public void Disattiva() => Console.WriteLine("Disattivazione mouse.");
}

class SchedaVideo  //Modifica per observer e singleton
{

    private static SchedaVideo _istance;
    private List<IObserver> _observers = new List<IObserver>();
    private SchedaVideo() { }
    public static SchedaVideo GetInstance()
    {
        if (_istance == null) _istance = new SchedaVideo();
        return _istance;
    }

    // Metodi per Observer
    public void Allega(IObserver observer) => _observers.Add(observer);

    private void Notifica(string messaggio)
    {
        foreach (var o in _observers) o.Aggiorna(messaggio);
    }
    public void Avvia() {
    Console.WriteLine("Avviamento scheda video.");
    Notifica("Notifica avvio inviata al monitor");
    }
    public void Spegni() {
    Console.WriteLine("Spegnimento scheda video.");
    Notifica("Notifica spegnimento inviata al monitor");
    }
}


class GamingSetupFacade
{
    private Monitor _monitor;
    private Tastiera _tastiera;
    private Mouse _mouse;
    private SchedaVideo _schedavideo;

    public GamingSetupFacade()
    {
        _monitor = new Monitor();
        _tastiera = new Tastiera();
        _mouse = new Mouse();
        _schedavideo = SchedaVideo.GetInstance();
        _schedavideo.Allega(_monitor);
        }

    public void AvviaPostazione()
    {
        Console.WriteLine("\nAvvio postazione in corso...");
        _monitor.Accendi();
        _schedavideo.Avvia();
        _tastiera.Attiva();
        _mouse.Attiva();
        Console.WriteLine("La postazione è pronta.\n");
    }

    public void SpegniPostazione()
    {
        Console.WriteLine("\nSpegnimento postazione in corso...");
        _tastiera.Disattiva();
        _mouse.Disattiva();
        _schedavideo.Spegni();
        _monitor.Spegni();
        Console.WriteLine("La postazione è stata spenta con successo.\n");
    }
}

//Aggiunta extra observer

interface IObserver
{
    void Aggiorna(string messaggio);
}