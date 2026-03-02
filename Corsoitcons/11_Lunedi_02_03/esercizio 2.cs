using System;

public class Macchina
{
    public string Motore;
    public float VelocitaMac;
    public int SospensioniMax;
    public int NrModifiche;

    public Macchina(string motore, float velocita, int sospensioni)
    {
        Motore = motore;
        VelocitaMac = velocita;
        SospensioniMax = sospensioni;
        NrModifiche = 0;
    }

    public void Stampa()
    {
        Console.WriteLine($"Motore: {Motore} | Velocità: {VelocitaMac} | Sospensioni: {SospensioniMax} | Modifiche: {NrModifiche}");
    }
}

public class Utente
{
    public string Nome;
    public int Credito;

    public Utente(string nome)
    {
        Nome = nome;
        Credito = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("       SISTEMA DI MODIFICA VEICOLI");
            Console.WriteLine();


            Console.Write("Inserisci il nome del nuovo utente (o 'esci'): ");
            string nomeInput = Console.ReadLine();
            if (nomeInput.ToLower() == "esci") break;

            Utente utenteCorrente = new Utente(nomeInput);


            Macchina[] garage = new Macchina[3] {
                new Macchina("Panda", 120, 5),
                new Macchina("Jaguar", 200, 10),
                new Macchina("Ferrari", 230, 15)
            };

            Console.WriteLine($"\nBenvenuto {utenteCorrente.Nome}. Scegli l'auto da modificare:");
            for (int i = 0; i < garage.Length; i++)
            {
                Console.Write($"{i + 1}) ");
                garage[i].Stampa();
            }

            int sceltaAuto;
            while (!int.TryParse(Console.ReadLine(), out sceltaAuto) || sceltaAuto < 1 || sceltaAuto > 3)
                Console.Write("Scelta non valida! Digita 1, 2 o 3: ");

            Macchina autoSelezionata = garage[sceltaAuto - 1];

            
            Console.Write($"\nQuanto credito vuoi assegnare a {utenteCorrente.Nome}? ");
            int creditoInput;
            while (!int.TryParse(Console.ReadLine(), out creditoInput) || creditoInput < 0)
                Console.Write("Inserisci un numero valido: ");
            
            utenteCorrente.Credito = creditoInput;

            while (utenteCorrente.Credito > 0)
            {
                
                Console.WriteLine($"Utente: {utenteCorrente.Nome} | Credito Residuo: {utenteCorrente.Credito}");
                autoSelezionata.Stampa();
                
                Console.WriteLine("Seleziona modifica (Costo 1):");
                Console.WriteLine("1) +10 Velocità | 2) Cambia Nome Auto | 3) +1 Sospensioni | 0) Termina");
                
                string azione = Console.ReadLine();
                if (azione == "0") break;

                bool modificaEffettuata = false;

                switch (azione)
                {
                    case "1":
                        autoSelezionata.VelocitaMac += 10;
                        modificaEffettuata = true;
                        break;
                    case "2":
                        Console.Write("Nuovo nome auto: ");
                        autoSelezionata.Motore = Console.ReadLine();
                        modificaEffettuata = true;
                        break;
                    case "3":
                        autoSelezionata.SospensioniMax += 1;
                        modificaEffettuata = true;
                        break;
                    default:
                        Console.WriteLine("Comando non riconosciuto.");
                        break;
                }

                if (modificaEffettuata)
                {
                    autoSelezionata.NrModifiche++;
                    utenteCorrente.Credito--; 
                    Console.WriteLine(" Modifica applicata con successo!");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"RIEPILOGO  {utenteCorrente.Nome}");
            autoSelezionata.Stampa();
            Console.WriteLine();
            Console.WriteLine("Premi invio per cambiare utente...");
            Console.ReadLine();
        }
    }
}