using System;
using System.Diagnostics.Contracts;
using System.Globalization;

class Program
{
    static void Main()
    {
        Chef chef1 = Chef.GetInstance(); //singleton
        
        Console.Clear();
        Console.WriteLine("Benvenuto al ristorante");
        Console.WriteLine("Inserisci il tuo nome");
        string nomeinserito = Console.ReadLine() ?? "Ospite" ;

        //In questo modo inseriamo l utente come observer
        Cliente cliente1 = new Cliente(nomeinserito);
        chef1.Registra(cliente1);

        //Qui viene richiamato il factory method
        Console.WriteLine($"Buonasera {nomeinserito}, cosa vuoi ordinare? \nScegli   \n1.Pizza, \n2.Hamburger, \n3.Insalata.");
        string scelta = Console.ReadLine();
        IPiatto piattoOrdinato = PiattoFactory.Crea(scelta);

        if (piattoOrdinato == null)
        {
            Console.WriteLine("Piatto non trovato, chiusura menù...");
            return;
        }
        //Qui entrano in gioco i decoratori
        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\n Quale ingrediente vuoi aggiungere?");
            Console.WriteLine("1: Formaggio, 2:Bacon, 3:Salsa, 4:Nessuno/Stop");
            string extra = Console.ReadLine();

            if (extra == "1") piattoOrdinato = new ConFormaggio(piattoOrdinato);
            else if (extra == "2") piattoOrdinato = new ConBacon(piattoOrdinato);
            else if (extra == "3") piattoOrdinato = new ConSalsa(piattoOrdinato);
            else continua = false;
        }

        //Richiamo al pattern strategy
        bool  continua2 = false;
        while (!continua2){
        Console.WriteLine("\n Come vuoi che sia preparato?");
        Console.WriteLine("1: Al forno, 2: Fritto, 3: Alla griglia");
        string modprep = Console.ReadLine();

        if (modprep == "1"){ chef1.SetStrategia(new AlForno()); continua2 = true;}
        else if (modprep == "2"){ chef1.SetStrategia(new Fritto()); continua2 = true;}
        else if (modprep == "3") {chef1.SetStrategia(new AllaGriglia());continua2 = true;}
        else Console.WriteLine("Scelta non valida! Inserisci 1, 2 o 3.");
        }

        Console.WriteLine("Lo chef sta preparando:");
        chef1.PreparaPiatto(piattoOrdinato);
    }
}