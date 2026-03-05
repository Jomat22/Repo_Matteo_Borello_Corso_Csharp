using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Corso> catalogo = new List<Corso>();
        List<Docente> docentiDisponibili = new List<Docente>
        {
            new Docente("Arturo Gray","materia"),
            new Docente("Camilla Douglas","materia"),
            new Docente("Marco Bianchi","materia"),
            new Docente("Giulia Rossi","materia")
        };

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nMenu Ente Formativo");
            Console.WriteLine("1. Nuovo Corso Presenza\n2. Nuovo Corso Online\n3. Catalogo\n4. Esci");
            string scelta = Console.ReadLine() ?? "";

            if (scelta == "1" || scelta == "2")
            {
                Console.Write("Inserisci Titolo: ");
                string tit = Console.ReadLine() ?? "";

                Console.Write("Inserisci Durata (ore): ");
                int ore = int.Parse(Console.ReadLine() ?? "0");


                Console.WriteLine("Scegli un docente (1-4):");
                for (int i = 0; i < docentiDisponibili.Count; i++)
                    Console.WriteLine((i + 1) + ". " + docentiDisponibili[i].Nome);
                
                int dIndex = int.Parse(Console.ReadLine() ?? "1") - 1;
                Docente doc = docentiDisponibili[dIndex];

                if (scelta == "1")
                {
                    Console.Write("Inserisci Aula: ");
                    string aula = Console.ReadLine() ?? "";
                    Console.Write("Inserisci Numero Posti: ");
                    int posti = int.Parse(Console.ReadLine() ?? "1");
                    
                    catalogo.Add(new CorsoInPresenza(tit, ore, doc, aula, posti));
                }
                else
                {
                    Console.Write("Inserisci Piattaforma (es. Gotoo o zoom): ");
                    string piattaforma = Console.ReadLine() ?? "";
                    catalogo.Add(new CorsoOnline(tit, ore, doc, piattaforma));
                }
                Console.WriteLine("Corso creato con successo!");
            }
            else if (scelta == "3")
            {
                foreach (Corso c in catalogo)
                {
                    c.StampaDettagli(); 
                    c.ErogaCorso();    
                    Console.WriteLine();
                }
            }
            else if (scelta == "4") continua = false;
        }
    }
}