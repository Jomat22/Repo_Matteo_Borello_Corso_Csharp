using System;

public class CorsoMusica : Corso
{
    public string Strumento;

    public CorsoMusica(string nome, int durata, string docente, string strumento): base(nome, durata, docente)
    {
        Strumento = strumento;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Strumento: {Strumento}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si tiene una prova pratica dello strumento: {Strumento}");
    }
}

public class CorsoPittura : Corso
{
    public string Tecnica;

    public CorsoPittura(string nome, int durata, string docente, string tecnica): base(nome, durata, docente)
    {
        Tecnica = tecnica;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Tecnica: {Tecnica}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Si lavora su una tela con tecnica: {Tecnica}");
    }
}

public class CorsoDanza : Corso
{
    public string Stile;

    public CorsoDanza(string nome, int durata, string docente, string stile): base(nome, durata, docente)
    {
        Stile = stile;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Stile: {Stile}";
    }

    public override void MetodoSpeciale()
    {
        Console.WriteLine($"Esecuzione coreografia nello stile: {Stile}");
    }
}