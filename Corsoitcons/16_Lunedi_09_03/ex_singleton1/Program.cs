using System;

public class Program
{
    public static void Main(string[] args)
    {
        Logger Logger1 = Logger.GetIstanza();
        Logger1.ScriviMessaggio("Esempio messaggio 1");

        Logger Logger2 = Logger.GetIstanza();
        Logger2.ScriviMessaggio("Esempio messaggio 2");

        if (ReferenceEquals(Logger1, Logger2))
        {
            Console.WriteLine("Controllo che Logger1 e Logger2 abbiano la stessa istanza: esito positivo");
        }
        else
        {
            Console.WriteLine("Le istanze sono diverse");
        }
    }
}