using System.Collections;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Questo è un cerchio");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Questo è un quadrato");
    }
}