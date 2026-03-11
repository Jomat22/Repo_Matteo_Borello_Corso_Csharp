using System;

public interface IStrategiaOperazione
{
    double Calcola(double a, double b);
    }

    public class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b) => a + b;
}
    public class SottrazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b) => a - b;
}
    public class MoltiplicazioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b) => a * b;
}
    public class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b) => a / b;
}

public class Calcolatrice
{
    private IStrategiaOperazione strategia;

    public void ScegliStrategia(IStrategiaOperazione newstrategia)
    {
        this.strategia = newstrategia;
    }

    public double EseguiStrategia(double a, double b)
    {
        if (strategia == null)
        {
            Console.Write("nessuna operazione selezionata");
            return 0;
        }
        return strategia.Calcola(a, b);
    }
}