using System;

//Ereditarietà (Classi derivate)

public class Lavoratore : Persona {
    private string _orarioTurno;

    // Costruttore  (con i vari parametri)
    public Lavoratore(string nome, string ruolo, Badge badge, string orario) : base(nome, ruolo, badge) {
        _orarioTurno = orario;
    }

    public string OrarioTurno {
        get { return _orarioTurno; }
        set { _orarioTurno = value; }
    }

    //metodi override (di abstract persona)
    public override void ProtocolloAccesso() {
        Console.WriteLine($"LOG Lavoratore {Nome}: Badge e verifica riuscita.");
    }

    public override string InfoTurno() {
        return "Turno Lavorativo: " + _orarioTurno;
    }
}

public class CollaboratoreEsterno : Persona {
    private string _societaEsterna;
    private string _progettoAssegnato;

    //Costruttore (con i vari parametri)
    public CollaboratoreEsterno(string nome, string ruolo, Badge badge, string societa, string progetto) : base(nome, ruolo, badge) {
        _societaEsterna = societa;
        _progettoAssegnato = progetto;
    }

    public string SocietaEsterna
    {
    get { return _societaEsterna; } 
    set { _societaEsterna = value; } 
    }
    public string ProgettoAssegnato 
    {
    get { return _progettoAssegnato; } 
    set { _progettoAssegnato = value; } 
    }

    //metodi override (di abstract persona)
    public override void ProtocolloAccesso() {
        Console.WriteLine($"LOG Collaboratore {Nome} ({SocietaEsterna}): Verifica progetto '{ProgettoAssegnato}'.");
    }

    public override string InfoTurno() {
        return $"Consulenza Esterna Progetto: {ProgettoAssegnato}";
    }
}