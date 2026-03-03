using System;

public class Soldato
{
    private string nome;
    private string grado;
    private int anniServizio;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Grado
    {
        get { return grado; }
        set { grado = value; }
    }

    public int AnniServizio
    {
        get { return anniServizio; }
        set 
        { 
            if (value >= 0) anniServizio = value;
            else anniServizio = 0;
        }
    }

    public Soldato(string nome, string grado, int anniServizio)
    {
        Nome = nome;
        Grado = grado;
        AnniServizio = anniServizio;
    }

    public virtual void Descrizione()
    {
        Console.Write($"Nome: {Nome}, Grado: {Grado}, Anni Servizio: {AnniServizio}");
    }
}