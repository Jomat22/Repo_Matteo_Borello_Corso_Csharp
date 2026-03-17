using System;

namespace EsercizioDI;

// classe per l'Esercizio 1
public class ConsoleGreeter : IGreeter
{
    public void Greet(string message) => Console.WriteLine($"[Messaggio]: {message}");
}

// classe per l'Esercizio 2
public class PaypalGateway : IPaymentGateway
{
    public void ProcessPayment(double amount) => 
        Console.WriteLine($"Pagamento di {amount}€ effettuato con successo tramite PayPal.");
}

public class StripeGateway : IPaymentGateway
{
    public void ProcessPayment(double amount) => 
        Console.WriteLine($"Pagamento di {amount}€ effettuato con successo tramite Stripe.");
}