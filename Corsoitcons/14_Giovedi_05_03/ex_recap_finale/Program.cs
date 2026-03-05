using System;

class Program {
    static void Main() {
        // Creazione Badge usando il costruttore
        Badge badgeDip = new Badge(101, true);
        Badge badgeColl = new Badge(505, true);
        Badge badgeCollneg = new Badge(505, false);

        // Creazione oggetti con una riga sola grazie ai costruttori
        Lavoratore d = new Lavoratore("Daniele Osteria", "Project Manager", badgeDip, "09:00 - 18:00");
        CollaboratoreEsterno c = new CollaboratoreEsterno("Giorgio Felci", "Sistemista", badgeColl, "TechSolutions", "Cloud 2024");
        Lavoratore d2 = new Lavoratore("Jhoan Russo", "Developer", badgeDip, "12:00 - 21:00");
        CollaboratoreEsterno c2 = new CollaboratoreEsterno("Leonardo DiCaprio", "Sistemista", badgeCollneg, "NewTech", "Server 2025");

        Console.WriteLine("Controllo Ingressi e Info:");
        
        // Il polimorfismo è necessario per far eseguire gli stessi metodi a più classi (oggetti)
        EseguiCicloCompleto(d);
        Console.WriteLine();
        EseguiCicloCompleto(c);
        Console.WriteLine();
        EseguiCicloCompleto(d2);
        Console.WriteLine();
        EseguiCicloCompleto(c2);
    }

    static void EseguiCicloCompleto(Persona p) {
        MostraRuolo(p);
        MostraTurno(p);
        ControllaAccesso(p);
        LogEntrataUscita(p, "REGISTRATO");
    }

    static void MostraRuolo(Persona p) {
        Console.WriteLine($"[INFO] Nome: {p.Nome} | Ruolo: {p.Ruolo}");
    }

    static void MostraTurno(Persona p) {
        Console.WriteLine($"[PIANO] {p.InfoTurno()}");
    }

    static void ControllaAccesso(Persona p) {
        Console.Write("Accesso? Esito: ");
        Console.WriteLine("");
        if (p.BadgeAssegnato.Attivo) {
            p.ProtocolloAccesso(); 
        } else {
            Console.WriteLine("Accesso NEGATO - Badge non attivo.");
        }
    }

    static void LogEntrataUscita(Persona p, string stato) {
        Console.WriteLine($"[LOG] {DateTime.Now} - Utente: {p.Nome} - Stato: {stato}");
    }
}