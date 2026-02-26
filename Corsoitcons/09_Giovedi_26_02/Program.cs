using System;
using System.Collections.Generic;

class newclass
{
    public static void Main(String[] args)
    {
        /* esercizio 1 dictionary
        Dictionary<string, long> rubrica = new Dictionary<string, long>
        {
            {"Marco Gallo", 3408562991},
            {"Andrea Ranieri", 3405401953},
            {"Giulia Fox", 3400091120},
        };
        foreach (var rubric in rubrica)
        {
            Console.WriteLine($"Il numero di {rubric.Key} è {rubric.Value}" );
        }
        
*/
        /*esercizio 2 dictionary

        Console.WriteLine("Inserisci una frase:");
        string input = Console.ReadLine();

        string[] parole = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string parola in parole)
        {
            string newpar = parola.ToLower();

            if (freq.ContainsKey(newpar))
                freq[newpar]++;
            else
                freq[newpar] = 1;
        }

        Console.WriteLine("Frequenza parole:");
        foreach (var text in freq)
        {
            Console.WriteLine($"{text.Key}: {text.Value}");
        }*/

        /*esercizio 3 dictionary  

        Dictionary<string, long> magazzino = new Dictionary<string, long>();
        string scelta = "";

        while (scelta != "5")
        {
            Console.WriteLine("1.Aggiungi/Modifica  2.Rimuovi  3.Cerca  4.Stampa  5.Esci");
            scelta = Console.ReadLine();

            if (scelta == "1")
            {
                Console.Write("Nome: "); string n = Console.ReadLine();
                Console.Write("Quantità (+ o -): "); long q = long.Parse(Console.ReadLine());
                if (magazzino.ContainsKey(n)) magazzino[n] += q; else magazzino[n] = q;
            }
            else if (scelta == "2")
            {
                Console.Write("Rimuovi: "); magazzino.Remove(Console.ReadLine());
            }
            else if (scelta == "3")
            {
                Console.Write("Inserisci il nome del prodotto da cercare: ");
                string n = Console.ReadLine();

                if (magazzino.ContainsKey(n))
                {
                    long q = magazzino[n];
                    Console.WriteLine($"Prodotto presente, Quantità: {q}");
                }
                else
                {
                    Console.WriteLine("Prodotto non presente");
                }
            }
            else if (scelta == "4")
            {
                foreach (var disp in magazzino)
                    Console.WriteLine($"{disp.Key}: {disp.Value}");
            }
        }
*/
        

    }
}
