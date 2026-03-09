using System.Collections.Generic;

public class RegistroVeicoli
{
    private static RegistroVeicoli istanza;
    private List<IVeicolo> veicoliCreati;

    private RegistroVeicoli()
    {
        veicoliCreati = new List<IVeicolo>();
    }

    public static RegistroVeicoli GetIstanza()
    {
        if (istanza == null)
        {
            istanza = new RegistroVeicoli();
        }
        return istanza;
    }

    public void Registra(IVeicolo veicolo)
    {
        if (veicolo != null)
        {
            veicoliCreati.Add(veicolo);
        }
    }

    public void StampaTutti()
    {
        Console.WriteLine("\nVeicoli disponibili");
        if (veicoliCreati.Count == 0) Console.WriteLine("Nessun veicolo disponibile.");
        
        foreach (var v in veicoliCreati)
        {
            v.MostraTipo();
        }
        Console.WriteLine();
    }
}