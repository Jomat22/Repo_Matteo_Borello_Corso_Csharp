using System;

class Program
{
    static void Main()
    {
        Calcolatrice miaCalcolatrice = new Calcolatrice();
        Console.Clear();

        Console.Write("Inserisci il primo numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Inserisci il secondo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nScegli l'operazione:");
        Console.WriteLine("1 - Somma");
        Console.WriteLine("2 - Sottrazione");
        Console.WriteLine("3 - Moltiplicazione");
        Console.WriteLine("4 - Divisione");
        Console.Write("Scelta: ");
        string scelta = Console.ReadLine();

        switch (scelta)
        {
            case "1":
                miaCalcolatrice.ScegliStrategia(new SommaStrategia());
                break;
            case "2":
                miaCalcolatrice.ScegliStrategia(new SottrazioneStrategia());
                break;
            case "3":
                miaCalcolatrice.ScegliStrategia(new MoltiplicazioneStrategia());
                break;
            case "4":
                miaCalcolatrice.ScegliStrategia(new DivisioneStrategia());
                break;
            default:
                Console.WriteLine("Scelta non valida.");
                return;
        }

        double risultato = miaCalcolatrice.EseguiStrategia(num1, num2);
        Console.WriteLine($"\nRisultato: {risultato:F2}");
    }
}