using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Esercito esercito1 = new Esercito();
        string scelta = "";

        while (scelta != "d")
        {
            Console.WriteLine("\n Scegli un'opzione a/b/c/d");
            Console.WriteLine("a. Aggiungi Fante");
            Console.WriteLine("b. Aggiungi Artigliere");
            Console.WriteLine("c. Visualizza tutti");
            Console.WriteLine("d. Esci");
            Console.Write("Selezione: ");
            scelta = Console.ReadLine().ToLower();

            if (scelta == "a" || scelta == "b")
            {
                Console.Write("Inserisci Nome: "); string n = Console.ReadLine();
                Console.Write("Inserisci Grado: "); string g = Console.ReadLine();
                Console.Write("Inserisci Anni Servizio: "); int anni = int.Parse(Console.ReadLine());

                if (scelta == "a")
                {
                    Console.Write("Inserisci Arma: "); string arma = Console.ReadLine();
                    esercito1.AggiungiSoldato(new Fante(n, g, anni, arma));
                }
                else
                {
                    Console.Write("Inserisci Calibro Arma: "); int cal = int.Parse(Console.ReadLine());
                    esercito1.AggiungiSoldato(new Artigliere(n, g, anni, cal));
                }
            }
            else if (scelta == "c")
            {
                esercito1.StampaTutti();
            }
        }
        
        Console.WriteLine("Programma terminato.");
    }
}