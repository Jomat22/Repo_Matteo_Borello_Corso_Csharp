class Program
{
    static void Main()
    {
        Console.WriteLine("--- GESTIONALE VOLI ---");
        Console.Write("Inserisci il codice del volo: ");
        string codiceIniziale = Console.ReadLine();

        VoloAereo mioVolo = new VoloAereo(codiceIniziale);

        bool uscire = false;
        while (!uscire)
        {
            Console.WriteLine("Scegli un'operazione:");
            Console.WriteLine("1) Prenota posti");
            Console.WriteLine("2) Annulla posti");
            Console.WriteLine("3) Visualizza stato");
            Console.WriteLine("4) Esci");
            Console.Write("Scelta: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("Quanti posti vuoi prenotare? ");
                    if (int.TryParse(Console.ReadLine(), out int p))
                        mioVolo.EffettuaPrenotazione(p);
                    break;

                case "2":
                    Console.Write("Quanti posti vuoi annullare? ");
                    if (int.TryParse(Console.ReadLine(), out int a))
                        mioVolo.AnnullaPrenotazione(a);
                    break;

                case "3":
                    mioVolo.VisualizzaStato();
                    break;

                case "4":
                    uscire = true;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
            
            if (scelta == "1" || scelta == "2")
                mioVolo.VisualizzaStato();
        }

        Console.WriteLine("Programma terminato");
    }
}