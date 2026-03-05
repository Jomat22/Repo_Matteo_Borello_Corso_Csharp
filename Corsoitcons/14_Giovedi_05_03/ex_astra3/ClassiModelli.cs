using System;

public class Docente
{
    private string _nome;
    private string _materia;

    public string Nome { get { return _nome; } set { _nome = value ?? ""; } }
    public string Materia { get { return _materia; } set { _materia = value ?? ""; } }

    public Docente(string nome, string materia)
    {
        Nome = nome;
        Materia = materia;
    }
}

public abstract class Corso
{
    private string _titolo;
    private int _durataOre;
    private Docente _docenteReferente;

    public string Titolo { get { return _titolo; } set { _titolo = value ?? ""; } }

    public int DurataOre
    {
        get { return _durataOre; }
        set { _durataOre = value >= 0 ? value : 0; } 
    }

    public Docente DocenteReferente { get { return _docenteReferente; } set { _docenteReferente = value; } }

    public Corso(string titolo, int durata, Docente docente)
    {
        Titolo = titolo;
        DurataOre = durata;
        DocenteReferente = docente;
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}