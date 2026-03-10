using System;

class Program {
    static void Main() {
        GestoreCreazioneUtente gestore = GestoreCreazioneUtente.Instance;
        
        ModuloLog log = new ModuloLog();
        ModuloMarketing marketing = new ModuloMarketing();

        string NomeCreato = "vuoto"; 
        bool continua = true;

        while (continua) {
            Console.WriteLine("\nMenu ");
            Console.WriteLine("1. Crea Utente");
            Console.WriteLine("2. Stampa Notifica LOG");
            Console.WriteLine("3. Stampa Notifica MARKETING");
            Console.WriteLine("4. Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta) {
                case "1":
                    Console.Write("Inserisci il nome: ");
                    NomeCreato = Console.ReadLine();
                    Utente u = UserFactory.Crea(NomeCreato);
                    Console.WriteLine(u.ToString());
                    Console.WriteLine(" Utente: " + NomeCreato + " generato con successo.");
                    break;

                case "2":
                    log.NotificaCreazione(NomeCreato);
                    break;

                case "3":
                    marketing.NotificaCreazione(NomeCreato);
                    break;

                case "4":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Opzione errata.");
                    break;
            }
        }
    }
}