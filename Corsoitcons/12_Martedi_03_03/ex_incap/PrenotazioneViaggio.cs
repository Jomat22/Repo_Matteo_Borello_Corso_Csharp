using System;

public class PrenotazioneViaggio
{
    private int postiPrenotati;
    private const int maxPosti = 20;
    private string _destinazione; 

    public string destinazione
    {
        get { return _destinazione; }
        set { _destinazione = value; }
    }

    public int PostiPrenotati
    {
        get { return postiPrenotati; }
    }

    public int PostiDisponibili
    {
        get { return maxPosti - postiPrenotati; }
    }

    public void PrenotaPosti(int numero)
    {
        if (numero > 0 && numero <= PostiDisponibili)
        {
            postiPrenotati += numero;
            Console.WriteLine($"Prenotazione di {numero} posti eseguita.");
        }
        else
        {
            Console.WriteLine($"Errore: posti non disponibili per {numero} posti.");
        }
    }

    public void AnnullaPrenotazione(int numero)
    {
        if (numero > 0 && numero <= postiPrenotati)
        {
            postiPrenotati -= numero;
            Console.WriteLine($"Annullamento di {numero} posti eseguito.");
        }
        else
        {
            Console.WriteLine($"Errore: annullamento non possibile.");
        }
    }
}