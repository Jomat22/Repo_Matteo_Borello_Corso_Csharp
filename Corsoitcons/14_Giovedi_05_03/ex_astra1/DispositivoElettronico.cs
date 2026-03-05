using System;

public abstract class DispositivoElettronico
{
    private string _modello;

    public string Modello
    {
        get
        {
            return _modello;
        }
        set
        {
            _modello = value;
        }
    }

    public DispositivoElettronico(string modello)
    {
        Modello = modello;
    }

    public abstract void Accendi();
    public abstract void Spegni();

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Modello dispositivo: {Modello}");
    }
}