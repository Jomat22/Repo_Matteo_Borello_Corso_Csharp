namespace EsercizioDI;

// Interfaccia per l'Esercizio 1
public interface IGreeter
{
    void Greet(string message);
}

// Interfaccia per l'Esercizio 2
public interface IPaymentGateway
{
    void ProcessPayment(double amount);
}