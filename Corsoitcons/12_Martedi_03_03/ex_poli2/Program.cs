using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        List<Operatore> listaOperatori = new List<Operatore>();
        bool continua = true;

        while (continua)
        {
            Console.WriteLine("\nScegli tra a/b/c/d");
            Console.WriteLine("a. Aggiungi Operatore");
            Console.WriteLine("b. Stampa lista Operatori");
            Console.WriteLine("c. Esegui Compito");
            Console.WriteLine("d. Esci");
            Console.Write("Scegli un'opzione: ");
            
            string scelta = Console.ReadLine().ToLower();

            switch (scelta)
            {
                case "a":
                    AggiungiOperatore(listaOperatori);
                    break;
                case "b":
                    StampaOperatori(listaOperatori);
                    break;
                case "c":
                    foreach (var op in listaOperatori){
                        Console.WriteLine($"{op.Nome}: ");
                        op.EseguiCompito();
                    }
                    break;
                case "d":
                    continua = false;
                    break;
                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
            }
        }
    }

    static void AggiungiOperatore(List<Operatore> lista)
    {
        Console.WriteLine("Tipo: 1.Emergenza, 2.Sicurezza, 3.Logistica");
        string tipo = Console.ReadLine();
        
        Operatore nuovo = null;
        if (tipo == "1") nuovo = new OperatoreEmergenza();
        else if (tipo == "2") nuovo = new OperatoreSicurezza();
        else if (tipo == "3") nuovo = new OperatoreLogistica();

        if (nuovo != null)
        {
            Console.Write("Nome: "); nuovo.Nome = Console.ReadLine();
            Console.Write("Turno (giorno/notte): "); nuovo.Turno = Console.ReadLine();

            if (nuovo is OperatoreEmergenza e) {
                Console.Write("Livello Urgenza (1-5): "); e.LivelloUrgenza = int.Parse(Console.ReadLine());
            } else if (nuovo is OperatoreSicurezza s) {
                Console.Write("Area Sorvegliata: "); s.AreaSorvegliata = Console.ReadLine();
            } else if (nuovo is OperatoreLogistica l) {
                Console.Write("Numero Consegne: "); l.NumeroConsegne = int.Parse(Console.ReadLine());
            }
            lista.Add(nuovo);
        }
    }

    static void StampaOperatori(List<Operatore> lista)
    {
        foreach (var op in lista)
        {
            Console.WriteLine($"[Tipo: {op.GetType().Name}] Nome: {op.Nome}, Turno: {op.Turno}");
        }
    }
}