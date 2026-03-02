using System;
using System.Collections.Generic;


class Film
{
    public string Titolo;
    public string Regista;
    public int Anno;
    public string Genere;

    public Film(string titolo, string regista, int anno, string genere)
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Film> videoteca = new List<Film>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\nInserimento Film " + (i + 1) + ":");

            Console.Write("Titolo: ");
            string titolo = Console.ReadLine();

            Console.Write("Regista: ");
            string regista = Console.ReadLine();

            Console.Write("Anno: ");
            int anno = int.Parse(Console.ReadLine());

            Console.Write("Genere: ");
            string genere = Console.ReadLine();

            videoteca.Add(new Film(titolo, regista, anno, genere));
        }

        Console.WriteLine("\nFilm inseriti");
        foreach (Film f in videoteca)
        {
            Console.WriteLine("Titolo: " + f.Titolo + " | Regia: " + f.Regista + " | Anno: " + f.Anno + " | Genere: " + f.Genere);
        }

        Console.Write("\nInserisci un genere per la ricerca: ");
        string cercaGenere = Console.ReadLine();
        bool trovato = false;

        Console.WriteLine("\n--- RISULTATI RICERCA ---");
        foreach (Film f in videoteca)
        {

            if (f.Genere.ToLower() == cercaGenere.ToLower())
            {
                Console.WriteLine("- " + f.Titolo + " diretto da " + f.Regista);
                trovato = true;
            }
        }

        if (!trovato)
        {
            Console.WriteLine("Nessun film trovato per il genere: " + cercaGenere);
        }
    }
}