using System;
using System.ComponentModel;

class Esercizi
{
    static void Main(string[] args)
    {

        //esercizio while 1
        /*
        int scelta = 0; 
        double saldo = 0;

        
        while (scelta != 4)
        {
            Console.WriteLine(" MENU BANCOMAT");
            Console.WriteLine("1. Visualizza saldo");
            Console.WriteLine("2. Deposita denaro");
            Console.WriteLine("3. Preleva denaro");
            Console.WriteLine("4. Esci");
            Console.Write("Scegliere un'opzione: ");

            
            if (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("Errore: Inserisci un numero valido.");
                continue; 
            }

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Saldo attuale: {saldo}€");
                    break;

                case 2:
                    Console.Write("Importo da depositare: ");
                    if (double.TryParse(Console.ReadLine(), out double deposito) && deposito > 0)
                    {
                        saldo += deposito;
                        Console.WriteLine("Deposito riuscito.");
                    }
                    else
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    break;

                case 3:
                    Console.Write("Importo da prelevare: ");
                    if (double.TryParse(Console.ReadLine(), out double prelievo) && prelievo > 0)
                    {
                        if (prelievo <= saldo)
                        {
                            saldo -= prelievo;
                            Console.WriteLine("Prelievo effettuato.");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insufficiente!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Importo non valido.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Arrivederci!");
                    break;

                default:
                    Console.WriteLine("Opzione non valida.");
                    break;
            }
        }

        */


        //esercizio do-while 1
/*
        const string password = "1234";
        string inputUtente;
        int tentativi = 3;
        bool accessoGarantito = false;

        Console.WriteLine("Benvenuto. Inserisci la password numerica.");

        do
        {
            Console.Write($"Inserisci password (Tentativi rimasti: {tentativi}): ");
            inputUtente = Console.ReadLine();

            if (inputUtente == password)
            {
                accessoGarantito = true;
            }
            else
            {
                tentativi--;
                if (tentativiRimasti > 0)
                {
                    Console.WriteLine("Password errata. Riprova.");
                }
            }

        } while (!accessoGarantito && tentativiRimasti > 0);

        if (accessoGarantito)
        {
            Console.WriteLine("Accesso effettuato ");
        }
        else
        {
            Console.WriteLine("Tentativi esauriti.");
        }

*/
        //esercizio do_while2

/*
        int numero;
        int somma = 0; 
        int totale = 0;

        Console.WriteLine("Inserisci numeri interi, 0 per terminare:");

        do
        {
            Console.Write("Numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                somma += numero;    
                totale++;        
            }

        } while (numero != 0);

        Console.WriteLine($"Somma totale: {somma}");
        Console.WriteLine($"Numeri validi inseriti: {totale}");
        */

        //esercizio do-while3 
        /*
        string continua;

        do
        {
            Console.Write("Inserisci il primo numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Inserisci l'operazione (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Inserisci il secondo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            double Risultato = 0;
            if (op == "+") Risultato = n1 + n2;
            else if (op == "-") Risultato = n1 - n2;
            else if (op == "*") Risultato = n1 * n2;
            else if (op == "/") Risultato = n2 != 0 ? n1 / n2 : 0;

            Console.WriteLine("Risultato: " + Risultato);

            Console.Write("per effetuare altra operazione premere s: ");
            continua = Console.ReadLine();

        } while (continua == "s");

        Console.WriteLine("Fine programma.");
*/


        //esercizio for 1
/*
        Console.WriteLine("Inserisci numero intero");
        int numUtente = int.Parse(Console.ReadLine());

        for (int i = 1; i <=10; i++)
        {
            Console.WriteLine($"{numUtente} x {i} = {numUtente * i}");
        }
*/
        //esercizio for 2
/*
        Console.WriteLine("Quanti numeri interi vuoi inserire?");
        int num = int.Parse(Console.ReadLine());

        int somma = 0;

        for(int i = 1; i <=num; i++)
        {
            Console.WriteLine($"inserisci numero {i}:");
            int numero = int.Parse(Console.ReadLine());
            somma += numero;
        }
        int media = somma / num;
        Console.WriteLine($"la media è:{media}");
*/
        //esercizio for 3
        /*

        Console.WriteLine("Dammi un numero positivo");
        int n = int.Parse(Console.ReadLine());

        if ( n< 0)
        {
            Console.WriteLine("dammi un numero positivo");
        }
        else
        {
            int fattoriale = 1;
            for (int i = 1; i <=n; i++)
            {
                fattoriale *=i;
            }
            Console.WriteLine($"fattoriale di n: {fattoriale}");
            */
        }

    }


}