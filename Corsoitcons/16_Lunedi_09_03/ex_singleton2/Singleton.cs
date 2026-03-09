using System;
using System.Collections.Generic;

public class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _instance;
    private Dictionary<string, string> _dati;

    private ConfigurazioneSistema()
    {
        _dati = new Dictionary<string, string>();
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
        _dati[chiave] = valore; 
    }

    public string Leggi(string chiave)
    {
        return _dati.ContainsKey(chiave) ? _dati[chiave] : "N/A";
    }

    public void StampaTutte()
    {
        Console.WriteLine("Configurazioni salvate");
        foreach (var input in _dati)
        {
            Console.WriteLine($"Chiave: {input.Key} | Valore: {input.Value}");
        }
    }
}