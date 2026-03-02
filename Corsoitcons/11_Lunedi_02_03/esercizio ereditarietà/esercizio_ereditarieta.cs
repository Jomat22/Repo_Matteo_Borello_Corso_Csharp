using System;
using System.Collections.Generic;

class Veicolo
{
    public string Marca;
    public string Modello;

    public Veicolo(string marca, string modello) 
    {
        this.Marca = marca;
        this.Modello = modello;
    }

    public virtual void StampaInfo()
    {
        Console.Write($"Marca: {Marca}, Modello: {Modello}");
    }
}

class Auto : Veicolo
{
    public int NumeroPorte;

    public Auto(string marca, string modello, int numeroPorte) : base(marca, modello)
    {
        NumeroPorte = numeroPorte;
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($", Porte: {NumeroPorte} [Auto]");
    }
}

class Moto : Veicolo
{
    public string TipoManubrio;

    public Moto(string marca, string modello, string tipoManubrio) : base(marca, modello)
    {
        TipoManubrio = tipoManubrio;
    }

    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($", Manubrio: {TipoManubrio} [Moto]");
    }
}

class Program
{
    static void Main()
    {
        List<Veicolo> veicoli = new List<Veicolo>();
        string scelta = "";

        while (scelta != "3")
        {
            Console.WriteLine("\n--- MENU GESTIONALE ---");
            Console.WriteLine("1. Inserisci Veicolo (Auto/Moto)");
            Console.WriteLine("2. Visualizza veicoli");
            Console.WriteLine("3. Esci");
            Console.Write("Scelta: ");
            scelta = Console.ReadLine();

            if (scelta == "1")
            {
                Console.Write("Tipo (A per Auto, M per Moto): ");
                string tipo = Console.ReadLine().ToUpper();

                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                Console.Write("Modello: ");
                string modello = Console.ReadLine();

                if (tipo == "A")
                {
                    Console.Write("Numero porte: ");
                    int porte = int.Parse(Console.ReadLine());
                    veicoli.Add(new Auto(marca, modello, porte));
                }
                else if (tipo == "M")
                {
                    Console.Write("Tipo manubrio: ");
                    string manubrio = Console.ReadLine();
                    veicoli.Add(new Moto(marca, modello, manubrio));
                }
            }
            else if (scelta == "2")
            {
                Console.WriteLine("\nElenco veicoli presenti:");
                foreach (Veicolo v in veicoli)
                {
                    v.StampaInfo();
                }
            }
        }
    }
}