using System;

class Program
{
    static void Main()
    {

        ConfigurazioneSistema moduloA = ConfigurazioneSistema.Instance;
        ConfigurazioneSistema moduloB = ConfigurazioneSistema.Instance;

        bool continua = true;

        while (continua)
        {
            Console.WriteLine("Menù scelta: ");
            Console.WriteLine("1. Modulo A: Imposta configurazione");
            Console.WriteLine("2. Modulo B: Leggi configurazione");
            Console.WriteLine("3. Crea e Avvia Dispositivo");
            Console.WriteLine("4. Controlla che i moduli usino la stessa istanza");
            Console.WriteLine("5. Stampa tutte le configurazioni");
            Console.WriteLine("0. Esci");
            Console.Write("Scelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Inserisci chiave: ");
                    string chiave = Console.ReadLine();
                    Console.Write("Inserisci valore: ");
                    string valore = Console.ReadLine();
                    moduloA.Imposta(chiave, valore);
                    Console.WriteLine("Configurazione salvata dal Modulo A.");
                    break;

                case "2":
                    Console.Write("Inserisci chiave da cercare: ");
                    string cerca = Console.ReadLine();
                    string risultato = moduloB.Leggi(cerca);
                    Console.WriteLine($"Il Modulo B ha letto: {risultato}");
                    break;

                case "3":
                    Console.Write("Inserisci tipo (computer/stampante): ");
                    string tipo = Console.ReadLine();
                    IDispositivo nuovoDisp = DispositivoFactory.CreaDispositivo(tipo);
                    
                    if (nuovoDisp != null)
                    {
                        nuovoDisp.Avvia();
                        nuovoDisp.MostraTipo();
                    }
                    else
                    {
                        Console.WriteLine("Errore: inserisci computer o stampante.");
                    }
                    break;

                case "4":
                    bool stessaIstanza = Object.ReferenceEquals(moduloA, moduloB);
                    Console.WriteLine($"\nControllo che i moduli siano nella stessa istanza: {stessaIstanza}");
                    break;

                case "5":
                    moduloA.StampaTutte();
                    break;

                case "0":
                    continua = false;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}