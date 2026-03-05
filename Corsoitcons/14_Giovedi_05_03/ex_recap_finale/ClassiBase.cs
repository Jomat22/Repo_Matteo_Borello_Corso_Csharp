using System;

public class Badge {

    //Incapsulamento
    private int _idCodice;
    private bool _attivo;

    // Costruttore
    public Badge(int id, bool stato) {
        _idCodice = id;
        _attivo = stato;
    }

    public int IdCodice { //get e set
        get { return _idCodice; }
        set { _idCodice = value; }
    }

    public bool Attivo {
        get { return _attivo; }
        set { _attivo = value; }
    }
}

public abstract class Persona {

    //Incapsulamento
    private string _nome;
    private string _ruolo;
    private Badge _badgeAssegnato;

    // Costruttore
    public Persona(string nome, string ruolo, Badge badge) {
        _nome = nome;
        _ruolo = ruolo;
        _badgeAssegnato = badge;
    }

    public string Nome {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Ruolo { 
        get { return _ruolo; }
        set { _ruolo = value; }
    }

    public Badge BadgeAssegnato { 
        get { return _badgeAssegnato; }
        set { _badgeAssegnato = value; }
    }
//metodi Astratti
    public abstract void ProtocolloAccesso();
    public abstract string InfoTurno();
}