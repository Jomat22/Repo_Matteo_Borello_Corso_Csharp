using System;

public class Logger
{
    private static Logger istanza;

    private Logger()
    {
        
    }

    public static Logger GetIstanza()
    {
        if (istanza == null)
        {
            istanza = new Logger();
        }
        return istanza;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now}] {messaggio}");
    }
}