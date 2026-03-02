/*
using System;

public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnoPubblicazione;

    public Libro(string titolo, string autore, int anno)
    {
        Titolo = titolo;
        Autore = autore;
        AnnoPubblicazione = anno;
    }

    public override string ToString()
    {
        return $"{Titolo}  {Autore} ({AnnoPubblicazione})";
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Libro librodiverso = (Libro)obj;

        return Titolo == librodiverso.Titolo && Autore == librodiverso.Autore;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Titolo, Autore);
    }
}


class Program
{
    static void Main()
    {
        // 4) Creo due oggetti Libro con gli stessi valori
        Libro libro1 = new Libro("Harry Potter", "Rowling", 1987);
        Libro libro2 = new Libro("Harry Potter", "Rowling", 1987);

        // Verifica ToString
        Console.WriteLine("ToString libro1: " + libro1.ToString());
        Console.WriteLine("ToString libro2: " + libro2.ToString());

        // Verifica Equals -> deve essere true
        Console.WriteLine("Equals: " + libro1.Equals(libro2));

        // Verifica GetHashCode -> devono essere uguali
        Console.WriteLine("HashCode libro1: " + libro1.GetHashCode());
        Console.WriteLine("HashCode libro2: " + libro2.GetHashCode());
        Console.WriteLine("HashCode uguali? " + (libro1.GetHashCode() == libro2.GetHashCode()));
    }
}
*/