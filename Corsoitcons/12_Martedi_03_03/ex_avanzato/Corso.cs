using System;
using System.Collections.Generic;

public class Corso
{
    public string NomeCorso;
    public int DurataOre;
    public string Docente;
    public List<string> Studenti;

    public Corso(string nome, int durata, string docente)
    {
        NomeCorso = nome;
        DurataOre = durata;
        Docente = docente;
        Studenti = new List<string>();
    }

    public void AggiungiStudente(string nomeStudente)
    {
        Studenti.Add(nomeStudente);
        Console.WriteLine($"Studente '{nomeStudente}' iscritto a {NomeCorso}.");
    }

    public virtual string ToString()
    {
        return $"[CORSO] {NomeCorso} - Docente: {Docente} ({DurataOre}h) - Iscritti: {Studenti.Count}";
    }

    public virtual void MetodoSpeciale()
    {
        Console.WriteLine();
    }
}