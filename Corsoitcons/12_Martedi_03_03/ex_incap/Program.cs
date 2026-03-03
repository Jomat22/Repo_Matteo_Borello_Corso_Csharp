using System;

class Program
{
    static void Main()
    {
        PrenotazioneViaggio viaggio = new PrenotazioneViaggio();


        Console.Write("Inserisci la destinazione del viaggio: ");
        string inputDestinazione = Console.ReadLine();
        viaggio.destinazione = inputDestinazione;

        Console.WriteLine($"\nViaggio per {viaggio.destinazione}");
        Console.WriteLine($"Posti disponibili: {viaggio.PostiDisponibili}");

        Console.Write("Quanti posti vuoi prenotare? ");
        int daPrenotare = int.Parse(Console.ReadLine());
        viaggio.PrenotaPosti(daPrenotare);

        Console.WriteLine($"Stato attuale: Prenotati {viaggio.PostiPrenotati}, Disponibili {viaggio.PostiDisponibili}");

        Console.Write("Quanti posti vuoi annullare? ");
        int daAnnullare = int.Parse(Console.ReadLine());
        viaggio.AnnullaPrenotazione(daAnnullare);

        Console.WriteLine($"Stato finale: Prenotati {viaggio.PostiPrenotati}, Disponibili {viaggio.PostiDisponibili}");
    }
}