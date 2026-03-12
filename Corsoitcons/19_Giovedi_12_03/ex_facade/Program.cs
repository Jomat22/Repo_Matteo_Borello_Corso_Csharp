using System;

class Program {
    static void Main(string[] args) {
        GamingSetupFacade computer = new GamingSetupFacade();
        string scelta = "";
        Console.Clear();

        while (scelta != "0") {
            Console.WriteLine("Cosa vuoi fare con il pc? Scegli 1/2.");
            Console.WriteLine("1. Accendi tutto");
            Console.WriteLine("2. Spegni tutto");
            Console.WriteLine("0. Esci");
            Console.Write("Seleziona opzione: ");
            scelta = Console.ReadLine();

            switch (scelta) {
                case "1":
                    computer.AvviaPostazione();
                    break;
                case "2":
                    computer.SpegniPostazione();
                    break;
                case "0":
                    Console.WriteLine("Uscita dal programma...");
                    break;
                default:
                    Console.WriteLine("Opzione non valida, riprova.");
                    break;
            }
        }
    }
}