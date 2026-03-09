using System;

class Program
{
    static void Main(string[] args)
    {
        RegistroVeicoli registro = RegistroVeicoli.GetIstanza();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("Gestione veicoli");
            Console.WriteLine("1. Crea e registra un'Auto");
            Console.WriteLine("2. Crea e registra una Moto");
            Console.WriteLine("3. Crea e registra un Camion");
            Console.WriteLine("4. Visualizza Registro Veicoli"); 
            Console.WriteLine("5. Esci");
            Console.Write("Scegli un'opzione: ");

            string scelta = Console.ReadLine();
            IVeicolo nuovoVeicolo = null;

            switch (scelta)
            {
                case "1":
                    nuovoVeicolo = VeicoloFactory.CreaVeicolo("auto");
                    break;
                case "2":
                    nuovoVeicolo = VeicoloFactory.CreaVeicolo("moto");
                    break;
                case "3":
                    nuovoVeicolo = VeicoloFactory.CreaVeicolo("camion");
                    break;
                case "4":
                    registro.StampaTutti();
                    break;
                case "5":
                    continua = false;
                    Console.WriteLine("Uscita dal programma");
                    break;
                default:
                    Console.WriteLine("Opzione non valida, riprova.");
                    break;
            }

            if (nuovoVeicolo != null)
            {
                nuovoVeicolo.Avvia();
                registro.Registra(nuovoVeicolo);
                Console.WriteLine("Veicolo aggiunto con successo!");
            }
        }
    }
}