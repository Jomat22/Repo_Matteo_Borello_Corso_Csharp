class Program
{
    static void Main(string[] args)
    {
        Printer myPrinter = new Printer();

        ILogger myConsoleLogger = new ConsoleLogger();

        myPrinter.Logger = myConsoleLogger;

        myPrinter.Print("Ciao, questo è un test di Dependency Injection!");
    }
}