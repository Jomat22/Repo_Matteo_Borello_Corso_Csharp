public class Caffe : IBevanda
{
    public string Descrizione()=> "Caffè";
    public double Costo()=> 1.00;
}

public class Te : IBevanda
{
    public string Descrizione()=> "TE";
    public double Costo()=> 2.50;
}

public abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda bevanda;

    public DecoratoreBevanda(IBevanda bevanda)
    {
        this.bevanda=bevanda;
    }

    public virtual string Descrizione()=> bevanda.Descrizione();
    public virtual double Costo()=> bevanda.Costo();
}

public class ConLatte :  DecoratoreBevanda{
    public ConLatte(IBevanda bevanda) : base(bevanda) {}

    public override string Descrizione()=> bevanda.Descrizione() + " con Latte";
    public  override double Costo()=> bevanda.Costo() + 0.50;
}

public class ConCioccolato : DecoratoreBevanda
{
    public ConCioccolato(IBevanda bevanda) : base(bevanda) { }

    public override string Descrizione()=> bevanda.Descrizione() + " con Cioccolato";
    public override double Costo() => bevanda.Costo() + 1.20;
}

public class ConPanna : DecoratoreBevanda
{
    public ConPanna(IBevanda bevanda) : base(bevanda) { }

    public override string Descrizione()=> bevanda.Descrizione() + " con Panna";
    public override double Costo() => bevanda.Costo() + 0.30;
}