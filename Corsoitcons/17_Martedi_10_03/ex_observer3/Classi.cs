using System;
using System.Collections.Generic;

class Utente {
    public string Nome;
    public override string ToString() => " Nome: " + Nome;
}

static class UserFactory {
    public static Utente Crea(string nome) => new Utente { Nome = nome };
}

class GestoreCreazioneUtente : ISoggetto {
    private static GestoreCreazioneUtente _instance;
    private List<IObserver> osservatori = new List<IObserver>();

    private GestoreCreazioneUtente() { } 

    public static GestoreCreazioneUtente Instance {
        get {
            if (_instance == null) _instance = new GestoreCreazioneUtente();
            return _instance;
        }
    }

    public void Registra(IObserver o) => osservatori.Add(o);
    public void Rimuovi(IObserver o) => osservatori.Remove(o);

    public void Notifica(string nomeUtente) {
        foreach (var o in osservatori) o.NotificaCreazione(nomeUtente);
    }
}

class ModuloLog : IObserver {
    public void NotificaCreazione(string nome) => 
        Console.WriteLine("Registrazione log di: " + nome);
}

class ModuloMarketing : IObserver {
    public void NotificaCreazione(string nome) => 
        Console.WriteLine("Email marketing inviata a: " + nome);
}