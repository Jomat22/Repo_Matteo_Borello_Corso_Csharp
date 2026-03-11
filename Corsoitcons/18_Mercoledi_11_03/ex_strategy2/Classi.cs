using System;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}

public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato con Carta di Credito.");
    }
}

public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato tramite PayPal.");
    }
}

public class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pagamento di {amount}€ effettuato in Bitcoin.");
    }
}

public class PaymentContext
{
    private IPaymentStrategy _strategy;
    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Pay(decimal amount)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Errore: Seleziona prima un metodo di pagamento!");
            return;
        }
        _strategy.Pay(amount);
    }
}