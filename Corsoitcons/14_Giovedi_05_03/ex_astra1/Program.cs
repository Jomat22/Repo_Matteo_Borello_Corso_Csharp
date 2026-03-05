using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            List<DispositivoElettronico> inventario = new List<DispositivoElettronico>();

            inventario.Add(new Computer("Computer1"));
            inventario.Add(new Stampante("Stampante1"));
            inventario.Add(new Computer("Computer1"));
            inventario.Add(new Stampante("Stampante2"));

            Console.WriteLine("Dispositivi\n");

            foreach (var dispositivo in inventario)
            {
                dispositivo.MostraInfo(); 
                dispositivo.Accendi();  
                dispositivo.Spegni();
                Console.WriteLine();
            }
        }
    }
