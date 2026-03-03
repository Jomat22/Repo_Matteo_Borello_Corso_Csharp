using System;

public class OperatoreEmergenza : Operatore
{
    private int livelloUrgenza;

    public int LivelloUrgenza
    {
        get { return livelloUrgenza; }
        set
        {
            if (value >= 1 && value <= 5)
                livelloUrgenza = value;
            else
                Console.WriteLine("Inserisci valore da 1 a 5");
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {livelloUrgenza}");
    }
}

public class OperatoreSicurezza : Operatore
{
    private string areaSorvegliata;

    public string AreaSorvegliata
    {
        get { return areaSorvegliata; }
        set { areaSorvegliata = value; }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {areaSorvegliata}");
    }
}

public class OperatoreLogistica : Operatore
{
    private int numeroConsegne;

    public int NumeroConsegne
    {
        get { return numeroConsegne; }
        set
        {
            if (value >= 0)
                numeroConsegne = value;
            else
                Console.WriteLine("Inserisci solo numero positivo");
        }
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {numeroConsegne} consegne");
    }
}