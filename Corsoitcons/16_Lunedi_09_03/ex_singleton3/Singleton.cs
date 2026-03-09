using System;
using System.Collections.Generic;

public class Logger
{
    private static Logger _instance;

    private List<string> Listalog;

    private Logger()
    {
        Listalog = new List<string>();
    }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
    }

    public void Log(string message)
    {
        Listalog.Add($"{DateTime.Now} - {message}");
    }

    public void PrintLogs()
    {
        Console.WriteLine("Registro Log");
        foreach (var input in Listalog)
        {
            Console.WriteLine(input);
        }
    }
}