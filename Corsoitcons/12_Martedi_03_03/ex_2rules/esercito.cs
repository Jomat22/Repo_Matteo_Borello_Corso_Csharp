using System;
using System.Collections.Generic;
public class Esercito
{
    private List<Soldato> soldati;

    public Esercito()
    {
        soldati = new List<Soldato>();
    }

    public void AggiungiSoldato(Soldato s)
    {
        soldati.Add(s);
        Console.WriteLine("Soldato all'esercito.");
    }

    public void StampaTutti()
    {
        Console.WriteLine("\n");
        if (soldati.Count == 0)
        {
            Console.WriteLine("L'esercito è vuoto.");
            return;
        }

        foreach (var s in soldati)
        {
            s.Descrizione();
        }
    }
}