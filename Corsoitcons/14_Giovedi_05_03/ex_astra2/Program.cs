using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IPagamento> metodiDisponibili = new List<IPagamento>();

        Console.WriteLine("Metodi Pagamento: ");


        Console.Write("Inserisci il circuito della tua carta (es. Visa, Mastercard): ");
        string circuitoInput = Console.ReadLine()!;
        metodiDisponibili.Add(new PagamentoCarta(circuitoInput));


        metodiDisponibili.Add(new PagamentoContanti());

        Console.Write("Inserisci la tua email PayPal: ");
        string emailInput = Console.ReadLine()!;
        metodiDisponibili.Add(new PagamentoPayPal(emailInput));

        Console.WriteLine("\nConfigurazione completata!");
        Console.WriteLine();

        Console.Write("Inserisci l'importo da pagare: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal importo))
        {
            Console.WriteLine("\nScegli quale metodo usare per questo pagamento:");
            for (int i = 0; i < metodiDisponibili.Count; i++)
            {
                Console.Write((i + 1) + ". ");
                metodiDisponibili[i].MostraMetodo();
            }

            Console.Write("\nScelta: ");
            if (int.TryParse(Console.ReadLine(), out int scelta) && scelta > 0 && scelta <= metodiDisponibili.Count)
            {
                IPagamento scelto = metodiDisponibili[scelta - 1];
                Console.WriteLine("\nPagamento:");
                scelto.EseguiPagamento(importo);
            }
            else
            {
                Console.WriteLine("Scelta non valida.");
            }
        }
        else
        {
            Console.WriteLine("Importo non valido.");
        }
    }
}