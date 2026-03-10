using System;

class Program
{
    static void Main()
    {
        NewsAgency agenzia = NewsAgency.Instance;

        agenzia.Registra(new MobileApp());
        agenzia.Registra(new EmailClient());

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Scrivi una notizia di aggiornamento (o 'exit' per uscire):");

        while (true)
        {
            Console.Write("\nInserisci News > ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "exit") break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                agenzia.News = input;
                Console.WriteLine("\nScrivi exit per terminare");
            }
        }
    }
}