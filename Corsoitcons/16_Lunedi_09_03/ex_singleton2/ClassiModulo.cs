using System;

public class ModuloA
{
    public void EsempioModulo1()
    {
        Console.WriteLine("Configurazione modulo1");
        ConfigurazioneSistema.Instance.Imposta("Modulo 1 key", "viuwbvdb");
    }
}

public class ModuloB
{
    public void EsempioModulo2()
    {
        Console.WriteLine("Configurazione modulo2");
        string ip = ConfigurazioneSistema.Instance.Leggi("Modulo 2 info: ");
        Console.WriteLine($"Modulo 2 collegato {ip}");
        
        ConfigurazioneSistema.Instance.Imposta("Modulo 2 key", "753975");
    }
}