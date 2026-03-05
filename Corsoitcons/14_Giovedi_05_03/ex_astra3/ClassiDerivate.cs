using System;

public class CorsoInPresenza : Corso
{
    private string _aula;
    private int _numeroPosti;

    public string Aula { get { return _aula; } set { _aula = value ?? ""; } }

    public int NumeroPosti
    {
        get { return _numeroPosti; }
        set { _numeroPosti = value >= 1 ? value : 1; } 
    }

    public CorsoInPresenza(string t, int d, Docente doc, string aula, int posti) : base(t, d, doc)
    {
        Aula = aula;
        NumeroPosti = posti;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine("Il corso in presenza è in aula: " + Aula);
    }

    public override void StampaDettagli()
    {
        Console.WriteLine("Dettagli corso in presenza: ");
        Console.WriteLine("Titolo: " + Titolo + " | Ore: " + DurataOre);
        Console.WriteLine("Docente: " + DocenteReferente.Nome + " | Posti: " + NumeroPosti);
    }
}

public class CorsoOnline : Corso
{
    private string _piattaforma;

    public string Piattaforma { get { return _piattaforma; } set { _piattaforma = value ?? ""; } }

    public CorsoOnline(string t, int d, Docente doc, string piattaforma) : base(t, d, doc) 
    { 
        Piattaforma = piattaforma; 
    }

    public override void ErogaCorso()
    {
        Console.WriteLine("Il corso è online su: " + Piattaforma);
    }

    public override void StampaDettagli()
    {
        Console.WriteLine("Dettagli corso online: ");
        Console.WriteLine("Titolo: " + Titolo + " | Ore: " + DurataOre);
        Console.WriteLine("Docente: " + DocenteReferente.Nome + " | Piattaforma: " + Piattaforma);
    }
}