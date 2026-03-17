namespace EsercizioDI;

// DI per l'Esercizio 1
public class GreetingService
{
    private readonly IGreeter _greeter;

    public GreetingService(IGreeter greeter)
    {
        _greeter = greeter;
    }

    public void Run() => _greeter.Greet("Prova dependency injection");
}

// DI per l'Esercizio 2
public class PaymentProcessor
{
    private readonly IPaymentGateway _gateway;

    public PaymentProcessor(IPaymentGateway gateway)
    {
        _gateway = gateway;
    }

    public void Execute(double total) => _gateway.ProcessPayment(total);
}