using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Quale veicolo vuoi creare? (auto, moto, camion):");
        string inputUtente = Console.ReadLine();

        IVeicolo veicolo = VeicoloFactory.CreaVeicolo(inputUtente);

        if (veicolo != null)
        {
            veicolo.Avvia();
            veicolo.MostraTipo();
        }
        else
        {
            Console.WriteLine("Errore immettere un veicolo presente.");
        }

    }
}