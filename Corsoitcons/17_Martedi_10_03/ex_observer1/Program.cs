using System;

class Program
{
    static void Main(string[] args)
    {
        CentroMeteo stazioneMeteo = new CentroMeteo();

        DisplayConsole displaycon = new DisplayConsole();
        DisplayMobile displaymob = new DisplayMobile();

        stazioneMeteo.Registra(displaycon);
        stazioneMeteo.Registra(displaymob);

        Console.WriteLine("Inserisci i nuovi dati meteo (es. Sole, Pioggia, Neve):");
        string inputUtente = Console.ReadLine();

        stazioneMeteo.AggiornaMeteo(inputUtente);

        Console.WriteLine("\nInserisci un secondo aggiornamento:");
        stazioneMeteo.AggiornaMeteo(Console.ReadLine());
    }
}