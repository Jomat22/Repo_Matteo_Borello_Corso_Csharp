using System;

public abstract class Animale
{
    private string _nome;
    private int _eta;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public int eta
    {
        get { return _eta; }
        set { _eta = value; }
    }

    public Animale(string nome, int eta)
    {
        _nome = nome;
        _eta = eta;
    }

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Nome : {_nome}, età : {_eta}");
    }

    public abstract void VersoAnimale();
}