using System;
using EsercizioDI;

class Program
{
    static void Main(string[] args)
    {
        // esercizio 1
        Console.WriteLine("Stampa messaggio tramite Dependecy Injection");
        IGreeter mioGreeter = new ConsoleGreeter();
        GreetingService service = new GreetingService(mioGreeter);
        service.Run();

        Console.WriteLine("\n------------------------------------\n");

        // esercizio 2
        Console.WriteLine("Seleziona il metodo di pagamento desiderato:");
        Console.WriteLine("1) PayPal");
        Console.WriteLine("2) Stripe");
        Console.WriteLine("3) Esci");
        Console.Write("\nScelta: ");

        string scelta = Console.ReadLine();
        IPaymentGateway gatewayScelto = null;

        switch (scelta)
        {
            case "1":
                gatewayScelto = new PaypalGateway();
                break;
            case "2":
                gatewayScelto = new StripeGateway();
                break;
            case "3":
                Console.WriteLine("Operazione annullata.");
                return; 
            default:
                Console.WriteLine("Scelta non valida. Operazione annullata");
                return;
        }

        if (gatewayScelto != null)
        {
            PaymentProcessor processor = new PaymentProcessor(gatewayScelto);
            
            Console.Write("Inserisci l'importo da pagare: ");
            if (double.TryParse(Console.ReadLine(), out double importo))
            {
                processor.Execute(importo);
            }
            else
            {
                Console.WriteLine("Errore: Importo non valido.");
            }
        }
    }
}