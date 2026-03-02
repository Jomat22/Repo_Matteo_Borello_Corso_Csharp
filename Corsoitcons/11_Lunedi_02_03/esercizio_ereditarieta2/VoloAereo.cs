using System;

class VoloAereo
{
    private int postiOccupati;
    private const int maxPosti = 150;
    private const int minPosti = 25;

    public string CodiceVolo { get; set; }

    public int PostiOccupati
    {
        get { return postiOccupati; }
    }
    public int PostiLiberi
    {
        get { return maxPosti - postiOccupati; }
    }

    public VoloAereo(string codice)
    {
        CodiceVolo = codice;
        postiOccupati = 0;
    }

    public void EffettuaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= PostiLiberi)
        {
            postiOccupati += numeroPosti;
            Console.WriteLine($">> Successo: {numeroPosti} posti prenotati.");
        }
        else
        {
            Console.WriteLine($">> Errore: Disponibili solo {PostiLiberi} posti.");
        }
    }

    public void AnnullaPrenotazione(int numeroPosti)
    {
        if (numeroPosti > 0 && numeroPosti <= postiOccupati)
        {
            postiOccupati -= numeroPosti;
            Console.WriteLine($">> Successo: {numeroPosti} posti annullati.");
        }
        else
        {
            Console.WriteLine(">> Errore: Numero di posti non valido per l'annullamento.");
        }
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"Volo: {CodiceVolo}");
        Console.WriteLine($"Posti Occupati: {PostiOccupati} / {maxPosti}");
        Console.WriteLine($"Posti Liberi:   {PostiLiberi}");
        
        if (postiOccupati >= minPosti)
        {
            Console.WriteLine("Status: CONFERMATO (Minimo raggiunto)");
        }
        else
        {
            Console.WriteLine($"Status: IN ATTESA (Mancano {minPosti - postiOccupati} posti al minimo)");
        }
        Console.WriteLine();
    }
}