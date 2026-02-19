using System;
using System.Security.Cryptography.X509Certificates;

class arraycoll
{
    public static void Main(string[] args)
    {
        /*
        bool ripeti = true;

        while (ripeti)
        {
            Console.WriteLine("Scegli il tipo di dati: 1. stringa o (altro) numeri interi");
            string scelta = Console.ReadLine();

            Console.WriteLine("Inserisci la lunghezza dell'array:");
            
            int lung = int.Parse(Console.ReadLine());

            if (scelta == "1")
            {
                string[] arrayStringhe = new string[lung];

                for (int i = 0; i < lung; i++)
                {
                    Console.WriteLine("Inserisci la stringa " + (i + 1));
                    arrayStringhe[i] = Console.ReadLine();
                }

                Console.WriteLine("Contenuto dell'array:");
                foreach (string s in arrayStringhe)
                {
                    Console.WriteLine(s);
                }
            } 
            else 
            {
                int[] arrayinteri = new int[lung];
                for (int i = 0; i < lung; i++)
                {
                    Console.WriteLine("Inserisci il numero " + (i + 1));
                    
                    arrayinteri[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Contenuto dell'array:");
                foreach (int n in arrayinteri)
                {
                    Console.WriteLine(n);
                }
            }

            
            Console.WriteLine("Vuoi continuare? (s)");
            if (Console.ReadLine() == "n")
            {
                ripeti = false;
            }
        }
        */

        //esercizio foreach 1

        /*

        Console.Write("Inserisci una frase: ");
        string input = Console.ReadLine();

        int contatore = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c)) 
            {
                contatore++;
            }
        }

        Console.WriteLine($"La frase contiene {contatore} cifre.");

        */

        //esercizio foreach 2
/*
        Console.Write("Inserisci una frase: ");
        string input = Console.ReadLine();

        string risultato = "";

        foreach (char c in input)
        {
            
            if ( !char.IsWhiteSpace(c))
            {
                risultato += c;
            }
        }

        Console.WriteLine($"Frase senza spazi: {risultato}");
        */

        //esercizio foreach 3

        /*

    Console.Write("Inserisci una stringa: ");
        string input = Console.ReadLine();

        int risultato = ContaVocali(input);

        Console.WriteLine($"Il numero di vocali contenute è: {risultato}");
    }

    public static int ContaVocali(string testo)
    {
        int conteggio = 0;
        string vocali = "aeiou";

        foreach (char c in testo)
        {
            
            char carattereMinuscolo = char.ToLower(c);

            
            if (vocali.Contains(carattereMinuscolo))
            {
                conteggio++;
            }
        }

        return conteggio;

        */

        Console.WriteLine("Inserisci una stringa:");
        string str = Console.ReadLine();

        
        Metodo(str);
        
        
        Console.WriteLine($"Analisi completata per: {str}");
    }

    public static void Metodo(string testo)
    {
        
        int conteggioLettere = 0;
        int conteggioSpazi = 0;
        int conteggioPunteggiatura = 0;

        foreach (char c in testo)
        {
            if (char.IsLetter(c))
                conteggioLettere++;
            else if (char.IsWhiteSpace(c)) 
                conteggioSpazi++;
            else if (char.IsPunctuation(c))
                conteggioPunteggiatura++;
        }

        
        string[] parole = testo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int totaleParole = parole.Length;


        Console.WriteLine(" Risultati");
        Console.WriteLine($"Numero di parole: {totaleParole}");
        Console.WriteLine($"Caratteri alfabetici: {conteggioLettere}");
        Console.WriteLine($"Spazi: {conteggioSpazi}");
        Console.WriteLine($"Punteggiatura: {conteggioPunteggiatura}");
    }
}