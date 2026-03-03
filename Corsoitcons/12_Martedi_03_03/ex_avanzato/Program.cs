using System;
using System.Collections.Generic;

class Program
{
    static List<Corso> listaCorsi = new List<Corso>();

    static void Main(string[] args)
    {
        string scelta = "";

        while (scelta != "0")
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("[1] Aggiungi un corso di Musica");
            Console.WriteLine("[2] Aggiungi un corso di Pittura");
            Console.WriteLine("[3] Aggiungi un corso di Danza");
            Console.WriteLine("[4] Aggiungi studente a un corso");
            Console.WriteLine("[5] Visualizza tutti i corsi");
            Console.WriteLine("[6] Cerca corsi per nome docente");
            Console.WriteLine("[7] Esegui metodo speciale di un corso");
            Console.WriteLine("[0] Esci");
            Console.Write("Scelta: ");
            scelta = Console.ReadLine();

            if (scelta == "1")
            {
                Console.Write("Nome: "); string n = Console.ReadLine();
                Console.Write("Ore: "); int o = int.Parse(Console.ReadLine());
                Console.Write("Docente: "); string d = Console.ReadLine();
                Console.Write("Strumento: "); string s = Console.ReadLine();
                CorsoMusica m = new CorsoMusica(n, o, d, s);
                listaCorsi.Add(m);
            }
            else if (scelta == "2")
            {
                Console.Write("Nome: "); string n = Console.ReadLine();
                Console.Write("Ore: "); int o = int.Parse(Console.ReadLine());
                Console.Write("Docente: "); string d = Console.ReadLine();
                Console.Write("Tecnica: "); string t = Console.ReadLine();
                CorsoPittura p = new CorsoPittura(n, o, d, t);
                listaCorsi.Add(p);
            }
            else if (scelta == "3")
            {
                Console.Write("Nome: "); string n = Console.ReadLine();
                Console.Write("Ore: "); int o = int.Parse(Console.ReadLine());
                Console.Write("Docente: "); string d = Console.ReadLine();
                Console.Write("Stile: "); string st = Console.ReadLine();
                CorsoDanza dz = new CorsoDanza(n, o, d, st);
                listaCorsi.Add(dz);
            }
            else if (scelta == "4")
            {
                for (int i = 0; i < listaCorsi.Count; i++)
                {
                    Console.WriteLine(i + " - " + listaCorsi[i].ToString());
                }
                Console.Write("Scegli l'indice del corso: ");
                int indice = int.Parse(Console.ReadLine());
                
                Console.Write("Nome studente: ");
                string nomeStud = Console.ReadLine();
                
                Corso corsoScelto = listaCorsi[indice];
                corsoScelto.AggiungiStudente(nomeStud);
            }
            else if (scelta == "5")
            {
                foreach (Corso c in listaCorsi)
                {
                    Console.WriteLine(c.ToString());
                }
            }
            else if (scelta == "6")
            {
                Console.Write("Nome docente: ");
                string cercato = Console.ReadLine();
                foreach (Corso c in listaCorsi)
                {
                    if (c.Docente == cercato)
                    {
                        Console.WriteLine(c.ToString());
                    }
                }
            }
            else if (scelta == "7")
            {
                for (int i = 0; i < listaCorsi.Count; i++)
                {
                    Console.WriteLine(i + " - " + listaCorsi[i].ToString());
                }
                Console.Write("Scegli l'indice del corso: ");
                int indice = int.Parse(Console.ReadLine());
                
                Corso corsoScelto = listaCorsi[indice];
                corsoScelto.MetodoSpeciale();
            }
        }
    }
}