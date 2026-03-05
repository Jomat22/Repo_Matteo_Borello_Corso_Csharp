using System;

public class PagamentoCarta : IPagamento
{
    private string _circuito;
    public string Circuito 
    { 
        get { return _circuito; } 
        set { _circuito = value; } 
    }

    public PagamentoCarta(string circuito)
    {
        _circuito = circuito;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine("Pagamento di " + importo + "€ effettuato con Carta (Circuito: " + _circuito + ").");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Carta di Credito");
    }
}

public class PagamentoContanti : IPagamento
{
    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine("Pagamento di " + importo + "€ effettuato in Contanti.");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("Contanti");
    }
}

public class PagamentoPayPal : IPagamento
{
    private string _email;
    public string Email 
    { 
        get { return _email; } 
        set { _email = value; } 
    }

    public PagamentoPayPal(string email)
    {
        _email = email;
    }

    public void EseguiPagamento(decimal importo)
    {
        Console.WriteLine("Pagamento di " + importo + "€ effettuato tramite PayPal (Account: " + _email + ").");
    }

    public void MostraMetodo()
    {
        Console.WriteLine("PayPal");
    }
}