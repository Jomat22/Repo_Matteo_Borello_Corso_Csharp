using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Veicolo> targhe = new List<Veicolo>();

        targhe.Add(new Auto("PO742HH"));
        targhe.Add(new Moto("MN102NC"));
        targhe.Add(new Camion("TY887MM"));

        Console.WriteLine("Lista targa dei veicoli");
        
        foreach (Veicolo v in targhe)
        {
            v.Ripara();
        }
    }
}