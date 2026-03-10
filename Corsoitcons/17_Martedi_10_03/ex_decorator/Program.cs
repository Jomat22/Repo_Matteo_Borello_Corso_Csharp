using System;

class Program
{
    static void Main()
    {
        IBevanda ordine = null;

        Console.WriteLine("Menù Bar");
        Console.WriteLine("Scegli la base:");
        Console.WriteLine("1. Caffè (1.00€)");
        Console.WriteLine("2. Tè (2.50€)");
        
        string sceltaBase = Console.ReadLine();

        if (sceltaBase == "1") {
            ordine = new Caffe();
        } else if (sceltaBase == "2") {
            ordine = new Te();
        } else {
            Console.WriteLine("Scelta non valida. Uscita...");
            return;
        }

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("\nCosa vuoi aggiungere?");
            Console.WriteLine("1. Latte (+0.50€)");
            Console.WriteLine("2. Cioccolato (+1.20€)");
            Console.WriteLine("3. Panna (+0.30€)");
            Console.WriteLine("0. Concludi ordine");

            string aggiunta = Console.ReadLine();

            switch (aggiunta)
            {
                case "1":
                    ordine = new ConLatte(ordine);
                    Console.WriteLine("Aggiunto Latte!");
                    break;
                case "2":
                    ordine = new ConCioccolato(ordine);
                    Console.WriteLine("Aggiunto Cioccolato!");
                    break;
                case "3":
                    ordine = new ConPanna(ordine);
                    Console.WriteLine("Aggiunta Panna!");
                    break;
                case "0":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
            }
        }

        Console.WriteLine("RIEPILOGO ORDINE:");
        Console.WriteLine($"Composizione: {ordine.Descrizione()}");
        Console.WriteLine($"Totale da pagare: {ordine.Costo():F2}€");
        
        Console.WriteLine("Grazie e a presto!");
    }
}