using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string[] studenti = new string[] { "Andrea", "Matteo", "Giovanni", "Edoardo", "Mirko" };
        string[] materie = new string[] { "Italiano", "Matematica", "Inglese", "Informatica", "Storia" };
        int[,] voti = new int[5, 5];
        Dictionary<string, int> indici_voti = new Dictionary<string, int>();
        indici_voti.Add("Andrea", 0);
        indici_voti.Add("Matteo", 1);
        indici_voti.Add("Giovanni", 2);
        indici_voti.Add("Edoardo", 3);
        indici_voti.Add("Mirko", 4);
        List<string> log = new List<string>();
        List<string> recenti = new List<string>();
        List<string> note_andrea = new List<string>();
        List<string> note_matteo = new List<string>();
        List<string> note_giovanni = new List<string>();
        List<string> note_edoardo = new List<string>();
        List<string> note_mirko = new List<string>();
        Random gen_voti = new Random();
        string studente;
        string selezione;
        float calcolo_media = 0;

        for(int i = 0; i < voti.GetLength(0); i++)
        {
            for(int j = 0; j < voti.GetLength(1); j++)
            {
                voti[i,j] = gen_voti.Next(0, 11);
            }
        }

        while (true)
        {
            Console.WriteLine("\n1 Visualizza,  2 Inserisci,  3 Statistiche, 4 Note & Log, 5 Ricerca 0 Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 0) break;

            switch (scelta)
            {
                //con la scelta numero 1 visualizziamo il registro
                case 1:
                    Console.Write("\tITA\tMAT\tING\tINF\tSTO\n");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(studenti[i] + "\t");
                        for (int j = 0; j < 5; j++) Console.Write(voti[i, j] + "\t");
                        Console.WriteLine();
                    }
                    log.Add("Visualizzato registro voti");
                    break;

                //con la scelta numero 2 aggiungiamo o aggiorniamo un voto
                case 2:
                    Console.Write("Indice Studente: 0 = Andrea, 1 = Matteo, 2 = Giovanni, 3 = Edoardo, 4 = Mirko ");
                    int s = int.Parse(Console.ReadLine());
                    Console.Write("Indice Materia: 0 = Italiano, 1 = Matematica, 2 = Ingelse, 3 = Informatica, 4 = Storia ");
                    int m = int.Parse(Console.ReadLine());
                    Console.Write("Voto: ");
                    voti[s, m] = int.Parse(Console.ReadLine());
                    log.Add($"Cambiato voto di {m} per {s}: ora è {voti[s,m]}");
                    break;

                //con la scelta numero 3 visualizziamo la media per ogni studente e ogni materia e 
                // il voto migliore presente sulla tabella
                case 3:
                    // 1. Calcolo Medie
                    for (int i = 0; i < 5; i++)
                    {
                        float sommaStudente = 0;
                        float sommaMateria = 0;

                        for (int j = 0; j < 5; j++)
                        {
                            sommaStudente += voti[i, j];
                            sommaMateria += voti[j, i];
                        }

                        Console.WriteLine($"Media {studenti[i]}: {sommaStudente / 5}");
                        Console.WriteLine($"Media {materie[i]}: {sommaMateria / 5}");
                    }

                    int votoMax = -1;
                    string studenteMax = "", materiaMax = "";

                    int votoMin = 11;
                    string studenteMin = "", materiaMin = "";

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (voti[i, j] > votoMax)
                            {
                                votoMax = voti[i, j];
                                studenteMax = studenti[i];
                                materiaMax = materie[j];
                            }
                            if (voti[i, j] !=0 && voti[i,j]< votoMin)
                            {
                                votoMin = voti[i, j];
                                studenteMin = studenti[i];
                                materiaMin = materie[j];
                            }
                        }
                    }
                    Console.WriteLine($"Voto migliore: {votoMax} di {studenteMax} in {materiaMax}");
                    Console.WriteLine($"Voto peggiore: {votoMin} di {studenteMin} in {materiaMin}");
                    log.Add("Visualizzati voti migliori e media di ogni studente");
                    break;
                case 4:
                    Console.WriteLine("Cosa vuoi fare?\n[1]-Aggiungi nota\t[2]-Riepilogo (ultime 10 azioni)\t[3]-Leggi note\t[4]-Torna indietro");
                    selezione = Console.ReadLine();
                    switch(selezione)
                    {
                        case "1":
                            Console.WriteLine("Scegli l'alunno: ");
                            for(int i = 0; i < studenti.Length; i++)
                            {
                                Console.WriteLine($"{i+1}-{studenti[i]}");
                            }
                            studente = Console.ReadLine();
                            switch(studente)
                            {
                                case "1":
                                    note_andrea.Add(AggiungiNota(studenti[0], ref log));
                                    break;

                                case "2":
                                    note_matteo.Add(AggiungiNota(studenti[1], ref log));
                                    break;

                                case "3":
                                    note_giovanni.Add(AggiungiNota(studenti[2], ref log));
                                    break;

                                case "4":
                                    note_edoardo.Add(AggiungiNota(studenti[3], ref log));
                                    break;

                                case "5":
                                    note_mirko.Add(AggiungiNota(studenti[4], ref log));
                                    break;

                                default:
                                    Console.WriteLine("Scelta non valida");
                                    break;
                            }
                            break;

                        case "2":
                            Console.WriteLine("Ultime 10 azioni:");
                            foreach(string l in log)
                            {
                                Console.WriteLine(l);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Scegli l'alunno: ");
                            for(int i = 0; i < studenti.Length; i++)
                            {
                                Console.WriteLine($"{i+1}-{studenti[i]}");
                            }
                            studente = Console.ReadLine();
                            switch(studente)
                            {
                                case "1":
                                    StampaNote(note_andrea);
                                    break;

                                case "2":
                                    StampaNote(note_matteo);
                                    break;

                                case "3":
                                    StampaNote(note_giovanni);
                                    break;

                                case "4":
                                    StampaNote(note_edoardo);
                                    break;

                                case "5":
                                    StampaNote(note_mirko);
                                    break;

                                default:
                                    Console.WriteLine("Scelta non valida");
                                    break;
                            }
                            break;

                        case "4":
                            break;
                    }
                    break;
                    case 5:
                        Console.WriteLine("[1]-Cerca uno studente in base al nome\n[2]-Cerca più studenti in base alla media\n[4]-Torna indietro");
                        selezione = Console.ReadLine();
                        switch(selezione)
                        {
                            case "1":
                                Console.WriteLine("Inserisci l'indice dello studente da cercare: ");
                                studente = Console.ReadLine();
                                if(indici_voti.Keys.Contains(studente))
                                {
                                    Console.Write($"{studente}: ");
                                    for(int i = 0; i < voti.GetLength(0); i++)
                                    {
                                        Console.Write($"{materie[i]}: {voti[indici_voti.GetValueOrDefault(studente), i]}\n");
                                    }
                                    AddToLog(ref log, $"Trovato studente {studente}");
                                }
                                else
                                {
                                    Console.WriteLine("Nessuno studente trovato");
                                    AddToLog(ref log, $"Nessuno studente trovato per: {studente}");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Inserisci la media di partenza: ");
                                int media = int.Parse(Console.ReadLine());
                                string operazione_recente = $"Studenti con media superiore a {media}: ";
                                for(int i = 0; i < voti.GetLength(0); i++)
                                {
                                    for(int j = 0; j < voti.GetLength(1); j++)
                                    {
                                        calcolo_media += voti[i,j];
                                    }
                                    calcolo_media = calcolo_media / voti.GetLength(1);
                                    if(calcolo_media > media)
                                    {
                                        Console.WriteLine($"{studenti[i]} (Media: {calcolo_media:F2})");
                                        if(recenti.Count >= 5)
                                        {
                                            recenti.RemoveAt(0);
                                        }
                                        operazione_recente += studenti[i] + ", ";
                                    }
                                    calcolo_media = 0;
                                }
                                break;
                            case "3":
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                        }
                        break;
                        default:
                            Console.WriteLine("Scelta non valida");
                            break;
                    
                
            }
        }
    }

    #region METODI ANDREA
    static string AggiungiNota(string alunno, ref List<string> n)
    {
        Console.WriteLine($"Scrivi la nota da inserire per {alunno}: ");
        n.Add($"Aggiunta nota a: {alunno}");
        return Console.ReadLine();
    }

    static void AddToLog(ref List<string> l, string arg)
    {
        if(l.Count >= 10)
        {
            l.RemoveAt(0);
        }
        l.Add(arg);
    }

    static void StampaNote(List<string> r)
    {
        foreach(string nota in r)
        {
            Console.WriteLine(nota);
        }
    }
    #endregion
}