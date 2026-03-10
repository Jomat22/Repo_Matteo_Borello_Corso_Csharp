using System;
using System.Collections.Generic;

public class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _instance;
    private Dictionary<string, string> _configurazioni;

    private ConfigurazioneSistema()
    {
        _configurazioni = new Dictionary<string, string>();
    }
    public static ConfigurazioneSistema Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurazioneSistema();
            }
            return _instance;
        }
    }

    public void Imposta(string chiave, string valore)
    {
        if (_configurazioni.ContainsKey(chiave))
            _configurazioni[chiave] = valore;
        else
            _configurazioni.Add(chiave, valore);
    }

    public string Leggi(string chiave)
    {
        if (_configurazioni.ContainsKey(chiave))
            return _configurazioni[chiave];
        return "Chiave non trovata";
    }

    public void StampaTutte()
    {
        Console.WriteLine("Configurazioni salvate");
        foreach (var elem in _configurazioni)
        {
            Console.WriteLine($"{elem.Key}: {elem.Value}");
        }
    }
}