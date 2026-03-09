using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Java;

class Program
{
    static void Main(string[] args)
    {
        ShapeCreator creazione = new ConcreteShapeCreator();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("Menu Forme");
            Console.WriteLine("Inserisci 1 per cerchio");
            Console.WriteLine("Inserisci 2 per quadrato");
            Console.WriteLine("Inserisci 0 per uscire");
            Console.WriteLine("Scelta:");

            string? scelta = Console.ReadLine();
            IShape? forma = null;

            switch (scelta)
            {
                case"1":
                forma = creazione.CreateShape("cerchio");
                break;
                case"2":
                forma = creazione.CreateShape("quadrato");
                break;
                case "0":
                continua = false;
                continue;
                default:
                Console.WriteLine("Inserisci scelta valida");
                break;
            }
            if (forma != null)
            {
                forma.Draw();
            }
        }
    }
}