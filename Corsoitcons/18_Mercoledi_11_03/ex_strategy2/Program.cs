using System;

class Program
{
    static void Main()
    {
        PaymentContext context = new PaymentContext();
        bool exit = false;
        Console.Clear();

        while (!exit)
        {
            Console.WriteLine("\nMenù sistema pagamento");
            Console.WriteLine("1. Carta di Credito");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Bitcoin");
            Console.WriteLine("4. Esci");
            Console.Write("Scegli un metodo di pagamento: ");

            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    context.SetStrategy(new CreditCardPayment());
                    context.Pay(100m);
                    break;
                case "2":
                    context.SetStrategy(new PayPalPayment());
                    context.Pay(100m);
                    break;
                case "3":
                    context.SetStrategy(new BitcoinPayment());
                    context.Pay(100m);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opzione non valida, riprova.");
                    break;
            }
        }
    }
}