class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.Instance;
        logger1.Log("Messaggio Logger1.");


        Logger logger2 = Logger.Instance;
        logger2.Log("Messaggio Logger2.");

        Console.WriteLine($"Controllo se i 2 logger hanno la stessa istanza (True/False) {Object.ReferenceEquals(logger1, logger2)}");

        logger2.PrintLogs();
    }
}