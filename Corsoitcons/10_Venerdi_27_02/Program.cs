using System;

class Program
{
    public static void Main(String[] args)
    {
        // Classe studente
        Studente studente1 = new Studente();
        
        studente1.Nome = "Bill Clinton";
        studente1.Matricola = 65837;
        studente1.MediaVoti = 22.3;

        Studente studente2 = new Studente();

        studente2.Nome = "Elon Musk";
        studente2.Matricola = 99431;
        studente2.MediaVoti = 28.2;


        Console.WriteLine("");
        Console.WriteLine($"Il nome dello studente 1 è {studente1.Nome} il suo numero matricola è {studente1.Matricola} e la sua media voti è {studente1.MediaVoti}");
        Console.WriteLine("");
        Console.WriteLine($"Il nome dello studente 2 è {studente2.Nome} il suo numero matricola è {studente2.Matricola} e la sua media voti è {studente2.MediaVoti}");
        Console.WriteLine("");

        //Classe Persona
        Persona persona1 = new Persona();
            
            persona1.Nome = "Margot";
            persona1.Cognome = "Robbie";
            persona1.AnnoNascita = 1990;

            Persona persona2 = new Persona();

            persona2.Nome = "Scarlett";
            persona2.Cognome = "Johanson";
            persona2.AnnoNascita = 1988;

            Console.WriteLine($"{persona1.Nome} {persona1.Cognome} è nato/a nel {persona1.AnnoNascita}");
            Console.WriteLine("");
            Console.WriteLine($"{persona2.Nome} {persona2.Cognome} è nato/a nel {persona2.AnnoNascita}");
            Console.WriteLine("");


            //Classe Operazioni
            Operazioni calcolo = new Operazioni();


            Console.Write("Inserisci il primo numero intero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Inserisci il secondo numero intero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            int somma1 = calcolo.Somma(num1, num2);
            calcolo.StampaRisultato("Somma", somma1);

            Console.WriteLine("");

            int moltiplicazione1 = calcolo.Moltiplica(num1, num2);
            calcolo.StampaRisultato("Moltiplicazione", moltiplicazione1);
            Console.WriteLine("");

    }
}