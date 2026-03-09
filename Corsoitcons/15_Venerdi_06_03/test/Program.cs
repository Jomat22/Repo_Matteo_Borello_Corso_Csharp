using System;
using System.Collections.Generic;

public class Program
{
    static List<Animale> fattoria = new List<Animale>();

    public static void Main()
    {
        fattoria.Add(new Mucca("Milka", 6, 11));
        fattoria.Add(new Gallina("Chica", 2, 1));
        fattoria.Add(new Pecora("Shawn", 5, 3));
        fattoria.Add(new Maiale("Babe", 2, 80.0));

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n--- OPZIONI FATTORIA ---");
            Console.WriteLine("1. Visualizza Animali e Versi");
            Console.WriteLine("2. Aggiungi Animale");
            Console.WriteLine("3. Elimina Animale");
            Console.WriteLine("4. Conteggio per Tipo");
            Console.WriteLine("5. Esci");
            Console.Write("Scelta: ");
            
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1": MostraTutti(); break;
                case "2": Aggiungi(); break;
                case "3": Elimina(); break;
                case "4": Conteggio(); break;
                case "5": continua = false; break;
                default: Console.WriteLine("Scelta non valida."); break;
            }
        }
    }

    static void MostraTutti()
    {
        Console.WriteLine("\n--- ELENCO ANIMALI ---");
        for (int i = 0; i < fattoria.Count; i++)
        {
            Console.Write($"{i}. ");
            fattoria[i].MostraInfo(); 
            Console.Write("  Lanimale fà: ");
            fattoria[i].VersoAnimale();
        }
    }

    static void Aggiungi()
    {
        Console.WriteLine("\nQuale animale vuoi aggiungere?");
        Console.WriteLine("1. Mucca (Litri Latte)");
        Console.WriteLine("2. Gallina (Uova/Giorno)");
        Console.WriteLine("3. Pecora (KG Lana)");
        Console.WriteLine("4. Maiale (Peso KG)");
        Console.Write("Scelta: ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: "); 
        string nome = Console.ReadLine();
        
        Console.Write("Età: "); 
        int eta = int.Parse(Console.ReadLine());
        switch (tipo)
        {
            case "1":
                Console.Write("Inserisci i litri di latte prodotti: ");
                int litri = int.Parse(Console.ReadLine());
                fattoria.Add(new Mucca(nome, eta, litri));
                break;
            case "2":
                Console.Write("Inserisci quante uova fa al giorno: ");
                int uova = int.Parse(Console.ReadLine());
                fattoria.Add(new Gallina(nome, eta, uova));
                break;
            case "3":
                Console.Write("Inserisci i KG di lana: ");
                int lana = int.Parse(Console.ReadLine());
                fattoria.Add(new Pecora(nome, eta, lana));
                break;
            case "4":
                Console.Write("Inserisci il peso del maiale: ");
                double peso = double.Parse(Console.ReadLine());
                fattoria.Add(new Maiale(nome, eta, peso));
                break;
            default:
                Console.WriteLine("Tipo non riconosciuto. Inserimento annullato.");
                break;
        }
    }

    static void Elimina()
    {
        MostraTutti();
        if (fattoria.Count == 0) return;
        Console.Write("\nInserisci l'indice dell'animale da eliminare: ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            if (index >= 0 && index < fattoria.Count)
            {
                fattoria.RemoveAt(index);
                Console.WriteLine("Animale rimosso con successo.");
            }
            else Console.WriteLine("Indice non valido.");
        }
    }

    static void Conteggio()
    {
        int m = 0, g = 0, p = 0, ma = 0;
        foreach (var a in fattoria)
        {
            if (a is Mucca) m++;
            else if (a is Gallina) g++;
            else if (a is Pecora) p++;
            else if (a is Maiale) ma++;
        }
        Console.WriteLine($"\nSTATISTICHE: \nMucche: {m}\nGalline: {g}\nPecore: {p}\nMaiali: {ma}");
    }
}