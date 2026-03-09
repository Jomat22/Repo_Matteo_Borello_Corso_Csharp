using System.Runtime.InteropServices;

public abstract class ShapeCreator
{
    public abstract IShape? CreateShape(string type);
}

public class ConcreteShapeCreator : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if (type.ToLower() == "cerchio")
        {
            return new Circle(); 
        }
        else if (type.ToLower() == "quadrato")
        {
            return new Square();
        }
        else
        {
            return null;
        }
    }
}