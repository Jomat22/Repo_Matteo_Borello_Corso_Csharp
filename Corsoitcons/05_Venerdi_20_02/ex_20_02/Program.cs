using System;

class newclass
{
    public static void Main(String[] args){

/*
    {
        //ex metodi 1

        static void Raddoppia(ref int numero)
        {
            numero = numero * 2;
        }

        int valore = 4;
        Console.WriteLine(valore);

        Raddoppia(ref valore);
        Console.WriteLine(valore);
    }
    */



    //ex metodi 2

    /*

    int giorno = 1;
    int mese = 1;
    int anno = 1;

AggiustaData(ref giorno, ref mese, ref anno);



static void AggiustaData(ref int giorno, ref int mese, ref int anno)
{

    if (giorno > 30)
    {
        giorno = 1;
        mese++; 
    }

    
    if (mese > 12)
    {
        mese = 1; 
        anno++;   
    }
}

*/
    //ex metodi 3

    /*

    static void Dividi(int a, int b, out int quoziente, out int resto)
{
    quoziente = a / b;
    resto = a % b;
}


Dividi(10, 3, out int q, out int r);
Console.WriteLine($"Q: {q}, R: {r}"); 
*/
    

    //ex metodi 4

    /*

    AnalizzaParola("ANALIZZAquestaparola", out int v, out int c, out int s);
    Console.WriteLine($"Vocali: {v}, Consonanti: {c}, Spazi: {s}");

    static void AnalizzaParola(string parola, out int vocali, out int consonanti, out int spazi)
        {
            vocali = 0;
            consonanti = 0;
            spazi = 0;

            string analizzavocali = "aeiouAEIOU";

            foreach (char c in parola)
            {
                if (analizzavocali.Contains(c))
                vocali++;
                else if ( char.IsWhiteSpace(c) )
                spazi++;
                else if (char. IsLetter(c) )
                consonanti++;
            }
            */

            // ex metodi 5

            
/*
            

            float somma = 0;
            int turni = 0;
            int punteggio = 10;
            int totale = 0;
            float media;

            AggiornaPunteggio(ref punteggio, 5, ref totale, out media);
            Console.WriteLine($"Punteggio: {punteggio}, Totale: {totale}, Media: {media}");
            

            void AggiornaPunteggio(ref int punteggiocorrente, int bonus, ref int totale, out float media)
            {
                punteggiocorrente += bonus;
                totale += punteggiocorrente;
                somma += punteggiocorrente;
                turni++;

                if (turni == 3)
                {
                    media = somma / 3;

                    turni = 0;
                    somma = 0;

                }
                else
                {
                    media = 0;
                }

            }
        }
        
        

        */


        //ex metodi 6

        double votoMatematica = 5.0;
        double votoFisica = 5.5;
        double puntoBonus = 1.0;
        double mediaRisultante; 

        bool promosso = ElaboraStudente(ref votoMatematica, ref votoFisica, puntoBonus, out mediaRisultante);


        Console.WriteLine(" Risultati ");
        Console.WriteLine($"Voti aggiornati: {votoMatematica} e {votoFisica}");
        Console.WriteLine($"Media finale: {mediaRisultante}");
        string esitoTesto;

        if (promosso == true) 
            {
                esitoTesto = "Promosso";
            }
                else 
            {
                esitoTesto = "Bocciato";
            }

        Console.WriteLine($"Esito: {esitoTesto}");


        static bool ElaboraStudente(ref double voto1, ref double voto2, double bonus, out double media)
        {
            voto1 = voto1 + bonus;
            voto2 = voto2 + bonus;

            media = (voto1 + voto2) / 2;


            return media >= 6;

        }

        
}

}