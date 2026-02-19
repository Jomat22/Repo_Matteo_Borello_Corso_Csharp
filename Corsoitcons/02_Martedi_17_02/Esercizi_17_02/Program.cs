using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;


class esercizi
{
    static void Main(string[] args){

        /*
        int a = 21;
        int b = 3;

        Console.WriteLine("somma di a+b:" +(a + b));

        double c = 12.34;

        Console.WriteLine("prezzo scontato:"+c * 0.2);

        float d = 55.3f;

        bool positivo = d > 0;

        Console.WriteLine("il numero è positivo?" + (d > 0));

        */


        //esercizio 4
/*
        Console.Write("Dammi un numero intero:");
        string n1 = Console.ReadLine();
        Console.Write("Dammi un  numero con la virgola:");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1); 
        float numero2 = float.Parse(n2);

        Console.WriteLine($"Somma: {numero1 + numero2}");


        //esercizio 5

        Console.WriteLine("Qual è la tua età?");
        string eta = Console.ReadLine();
        Console.WriteLine("Qual è la tua altezza?");
        string altezza = Console.ReadLine();

        int eta1 = int.Parse(eta);
        float altezza1 = float.Parse(altezza);

        Console.WriteLine($"somma età + altezza: {eta1 + altezza1}");
        */



        //esercizio 1 flussi
        
        /*

        const int maggioreeta = 18;

        Console.Write("Inserisci la tua età: ");
        string input = Console.ReadLine();

        int eta = int.Parse(input);

        if (eta >= maggioreeta)
        {
            Console.WriteLine("Sei maggiorenne.");
        }
        if  (eta < maggioreeta)
        {
            Console.WriteLine("Sei minorenne.");
        }
*/
        // esercizio flussi 2
        /*
        const double sconto = 50;

        Console.WriteLine("Prezzo prodotto:");
        string inputPrezzo = Console.ReadLine();

        double prezzo = double.Parse(inputPrezzo);

        double prezzoFinale = prezzo;

        if (prezzo > 40)
        {
            prezzoFinale = prezzo - (prezzo * sconto);

        }

        Console.WriteLine($"Prezzo finale: {prezzoFinale:F2} €");
*/


        // esercizio flussi 3
        /*
        Console.WriteLine("primo numero?");
        string num1 = Console.ReadLine();
        Console.WriteLine("secondo numero?");
        string num2 = Console.ReadLine();
        Console.WriteLine("terzo numero?");
        string num3 = Console.ReadLine();

        int numero1 = int.Parse(num1);
        int numero2 = int.Parse(num2);
        double numero3 = double.Parse(num3);

        Console.WriteLine($"somma dei numeri:  {numero1 + numero2 + numero3}");

        double sommanum = (numero1 + numero2 + numero3);

        if (sommanum >= 60)
        {
            Console.WriteLine("Hai superato la prova!");
        }
            if (sommanum < 60)
            {
                Console.WriteLine("Prova fallita");
            }
            */

            //else
            /*

            const int maggioreeta = 18;

        Console.Write("Inserisci la tua età: ");
        string input = Console.ReadLine();

        int eta = int.Parse(input);

        if (eta >= maggioreeta)
        {
            Console.WriteLine("Sei maggiorenne.");
        }
        else
        {
            Console.WriteLine("Sei minorenne.");
        }
        */

        //esercizio if-else
        /*

        Console.WriteLine("inserisci numero intero: ");
        string num1 = Console.ReadLine();

        int inputnum =  int.Parse(num1);

        if (inputnum % 2 == 0) 
        {
            Console.WriteLine("numero pari");
        }

        else
        {
            Console.WriteLine("numero dispari");
        }  
        */
        // esercizio if-else 2

/*
        const int password = 223;

        Console.Write("Inserisci la password numerica: ");
        string inputpassword = Console.ReadLine();

        int passwordnew = int.Parse(inputpassword);

        if (passwordnew == password)
        {
            Console.WriteLine("Accesso consentito.");
        }
        else
        {
            Console.WriteLine("Accesso negato.");
        }
        */

        // esempio if-elseif

/*
        int eta = 15;

        if (eta >= 18)
        {
            Console.WriteLine("Maggiorenne");
        }
        else if (eta>=13)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Bambino");
        }

*/

        //esercizio if-elseif 1
        /*
        Console.Write("inserisci un voto: ");
        string voto = Console.ReadLine();

        int votouser = int.Parse(voto);

        if (votouser  >= 1  && votouser <= 4)
        {
            Console.WriteLine("Insufficente");
        }
        else if (votouser >= 5 && votouser <= 6)
        {
            Console.WriteLine("sufficente");
        }
        else if (votouser >= 7 && votouser <= 8)
        {
            Console.WriteLine("buono");
        }
        else // >=9
        {
            Console.WriteLine("ottimo");
        }
        */

        //esercizio if-elseif 2

        /*

        Console.WriteLine("Inserisci il tuo peso: ");
        int peso = Console.ReadLine();

        Console.WriteLine("inserisci la tua altezza");
        double altezza = Console.ReadLine();

        double bmi = peso / (altezza * altezza);

        if (bmi < 18.5)
        {
            Console.WriteLine("Sottopeso");
        }
        else if (bmi >= 18.5 && bmi <25)
        {
            Console.WriteLine("Normopeso");

        }
        else if (bmi >= 25 && bmi < 30)
        {
            Console.WriteLine("Sovrappeso");
        }

        else // (bmi >= 30){
            Console.WriteLine("Obesità");
            */


            //esercizio if-elseif 3

/*
        Console.Write("inserisci il valore: ");
        double valore = double.Parse(Console.ReadLine());

        Console.Write("inserisci numero per valore da convertire 1(fahrenheit),2(kelvin),3(rankine)");
        string conversione = Console.ReadLine();

        if(conversione == "1")
        {
            double fahrenheit = (valore * 0.8d) + 32;
            Console.Write($"  fahrenheit: {fahrenheit}");
        }
        else if(conversione == "2")
        {
            double kelvin = valore + 273.15d;
            Console.Write($"   kelvin: {kelvin}");
        }
        else if(conversione == "3")
        {
            double rankine = (valore * 1.8d) + 491.67d;
            Console.Write($"   rankine: {rankine}");
        }
        */

        //esercizio case 1

/*
        Console.WriteLine("Metti un numero da 1 a 7");
        string numero = Console.ReadLine();

        int numeroutente = int.Parse(numero);

        switch (numeroutente)
        {
            case 1:
            Console.WriteLine("lunedi");
            break;
            case 2:
            Console.WriteLine("martedi");
            break;
            case 3:
            Console.WriteLine("mercoledi");
            break;
            case 4:
            Console.WriteLine("giovedi");
            break;
            case 5:
            Console.WriteLine("venerdi");
            break;
            case 6:
            Console.WriteLine("sabato");
            break;
            case 7:
            Console.WriteLine("domenica");
            break;
            default:
            console.WriteLine("numero non valido");
        }
*/
        //esercizio case 2
        /*

        Console.WriteLine("1.quadrato, 2.cerchio, 3.triangolo");
        int scelta = int.Parse(Console.ReadLine());
        
        switch (scelta)
        {
            case 1:
            Console.WriteLine("Inserisci il lato:");
            double lato = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (lato * lato));
            break;

            case 2:
            Console.WriteLine("Inserisci il raggio: ");
            double raggio =  double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (3.14 * raggio * raggio));
            break;

            case 3:
            Console.WriteLine("Inserisci base: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("iserisci altezza: ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + (b * h / 2));
            break;
            default:
            Console.WriteLine("inserisci numero da 1 a 3");
            
        }
        */

        //esercizio while 1

        /*

        int somma = 0;
        int num;

        Console.WriteLine("inserisci numeri positivi da sommare");
        Console.WriteLine("inserisci numero negativo per terminare");

        Console.WriteLine("inserisci un numero");
        num = int.Parse(Console.ReadLine());

        while (num >= 0)
        {
            somma += num;
            Console.WriteLine("inserisci altro numero");
            num = int.Parse(Console.ReadLine());

        }
        Console.WriteLine($"la somma totale dei numeri è: {somma}");
        */

        //esercizio while 2
/*
        const int numero_segreto =55;
        int prova = 0;

        Console.WriteLine("indovina il numero segreto");

        while ( prova != numero_segreto)
        {
            Console.WriteLine("inserisci prova");
            prova = int.Parse(Console.ReadLine());

            if (prova < numero_segreto)
            {
                Console.WriteLine("prova numero maggiore");
            }
            else if (prova > numero_segreto)
            {
                Console.WriteLine("prova numero minore");
            }
        }
        Console.WriteLine($"numero indovinato {numero_segreto}");
        */

        }


        



        }


        



    
