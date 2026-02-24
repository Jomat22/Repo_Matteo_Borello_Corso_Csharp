using System;
class newclass

{
    public static void Main(String[] args)
    {
        //esercizio random 1
        /*

        Random random= new Random();
        Console.WriteLine("Indovina il numero tra 1 e 10!");
        int numerocasuale = random.Next(11);
        int numutente = int.Parse(Console.ReadLine());

        if (numerocasuale == numutente)
        {
            Console.WriteLine("Numero indovinato");
        }
            else
            {
            Console.WriteLine("Numero errato");
            }
            */

        //esercizio random 2
        /*

        Random random = new Random();

        int dado1 = random.Next(1, 7);
        int dado2 = random.Next(1, 7);
        int somma = dado1 + dado2;

        Console.WriteLine($"Dado 1: {dado1}");
        Console.WriteLine($"Dado 2: {dado2}");
        Console.WriteLine($"Risultato totale: {somma}");
        */

        //esercizio random 3

        /*

        const int tempminima = -25, tempmassima = 37;
        Console.Write("Inserisci il numero di giorni: ");
        int numgiorni = int.Parse(Console.ReadLine());

        double[] temperature = new double[numgiorni];
        Random random = new Random();
        double somma = 0;
        
        double minima = tempmassima;
        double massima = tempminima;

        for (int i = 0; i < numgiorni; i++)
        {
            
            double tempGenerata = random.NextDouble() * (tempmassima - tempminima) + tempminima;
            temperature[i] = tempGenerata;

            somma += tempGenerata;
            if (tempGenerata < minima) minima = tempGenerata;
            if (tempGenerata > massima) massima = tempGenerata;
        }

        Console.WriteLine("\nTemperature generate:");
        foreach (var t in temperature) 
        {
            Console.Write($"{t:F1}°C ");
        }

        Console.WriteLine($"\nMinima:  {minima:F1}°C");
        Console.WriteLine($"Massima: {massima:F1}°C");
        Console.WriteLine($"Media:   {somma / numgiorni:F1}°C");
            */

            //esercizio matrici 1
            /*

        Console.Write("inserisci righe: ");
        int righe = int.Parse(Console.ReadLine());
        Console.Write("inserisci colonne: ");
        int colonne = int.Parse(Console.ReadLine());

        int[,] matrice = new int[righe, colonne];
        int somma = 0;

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                Console.Write($"Inserisci numero [{i},{j}]: ");
                matrice[i, j] = int.Parse(Console.ReadLine());
                somma += matrice[i, j];
            }
        }

        Console.WriteLine($"\nSomma: {somma}");

        for (int i = 0; i < righe; i++)
        {
            int sommariga = 0;
            for (int j = 0; j < colonne; j++) sommariga += matrice[i, j];
            Console.WriteLine($"Somma riga {i}: {sommariga}");
        }

        for (int j = 0; j < colonne; j++)
        {
            int sommacolonna = 0;
            for (int i = 0; i < righe; i++) sommacolonna += matrice[i, j];
            Console.WriteLine($"Somma colonna {j}: {sommacolonna}");
        }
        */

        //esercizio matrice 2

        /*

        int[,] mat1 = new int[4, 4];
        int[,] mat2 = new int[4, 4];
        Random random = new Random();
        int vittorieM1 = 0, vittorieM2 = 0;

        Console.WriteLine("Matrice 1: Matrice 2:");
        for (int i = 0; i < 4; i++)
        {
            string riga1 = "", riga2 = "";
            for (int j = 0; j < 4; j++)
            {
                mat1[i, j] = random.Next(51);
                mat2[i, j] = random.Next(51);
                riga1 += mat1[i, j] + "\t";
                riga2 += mat2[i, j] + "\t";
            }
            Console.WriteLine($"{riga1} | {riga2}");
        }

        Console.WriteLine("\nConfronto Righe:");
        for (int i = 0; i < 4; i++)
        {
            int s1 = 0, s2 = 0;
            for (int j = 0; j < 4; j++)
            {
                s1 += mat1[i, j];
                s2 += mat2[i, j];
            }
            
            Console.Write($"Riga {i}: Somma M1={s1}, Somma M2={s2} -> ");
            if (s1 > s2) { Console.WriteLine("Vince M1"); vittorieM1++; }
            else if (s2 > s1) { Console.WriteLine("Vince M2"); vittorieM2++; }
            else Console.WriteLine("Pareggio");
        }

        if (vittorieM1 > vittorieM2) Console.WriteLine("\nLa Matrice 1 ha vinto.");
        else if (vittorieM2 > vittorieM1) Console.WriteLine("\nLa Matrice 2 ha vinto");
        else Console.WriteLine("\nLe matrici hanno pareggiato");
        */

        //esercizio matrici 3
        /*

        int[,] matrice = new int[5, 5];
        Random random = new Random();
        int sommadiagonale1 = 0, sommadiagonale2 = 0;

        Console.WriteLine("Matrice 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrice[i, j] = random.Next(21);
                Console.Write($"  {matrice[i, j]}  ");
                
                if (i == j) sommadiagonale1 += matrice[i, j];
                

                if (i + j == 4) sommadiagonale2 += matrice[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSomma Diagonale1: {sommadiagonale1}");
        Console.WriteLine($"Somma Diagonale2: {sommadiagonale2}");

        if (sommadiagonale1 > sommadiagonale2)
            Console.WriteLine("La somma della Diagonale1 è maggiore.");
        else if (sommadiagonale1 < sommadiagonale2)
            Console.WriteLine("La somma della Diagonale2 è maggiore.");
        else
            Console.WriteLine("il risultato è uguale");
            */

            //esercizio array1
            /*
            Console.WriteLine("quanti numeri vuoi inserire?");
            int num= int.Parse(Console.ReadLine());
            int[] vettore = new int [num];
            int somma =0;

            for (int  i  = 0; i < num; i++)
        {
            Console.WriteLine($"inserisci il numero di {i + 1}");
            vettore[i] = int.Parse(Console.ReadLine());

            somma += vettore[i];
        }
        Console.WriteLine($"la somma dei numeri è {somma}");
        */

        //esercizio array 2
        /*

        Random random= new Random();
        int[] vettore = new int[10];

        for (int i = 0; i < 10; i++)
        {
        vettore[i] = random.Next(1, 101);
        }
        Console.WriteLine($"numeri casuali 1-100: {vettore[0]}");
        */

        //esercizio list 1
        

        List<int> interi = new List<int>();

        Console.WriteLine("inserisci 5 numeri interi");

        for (int i = 0; i < 5; i++)
        {
        
        Console.WriteLine($"numero{i + 1}:");
        int numeriutente = int.Parse(Console.ReadLine());
        interi.Add(numeriutente);

        }

        Console.Write("\nQuale numero vuoi rimuovere dalla lista? ");
        int elimina = int.Parse(Console.ReadLine());

        bool rimosso = interi.Remove(elimina);
        
        if (rimosso)
            Console.WriteLine($"Il numero {elimina} è stato rimosso.");
        else
            Console.WriteLine("Numero non presente.");

        Console.WriteLine("Numeri in lista:");
        foreach (int n in interi)
        {
            Console.WriteLine(n);
        }
        

        //esercizio list 2
        

        Random random = new Random();
        List<int> numeri = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            numeri.Add(random.Next(1, 101));
        }

            Console.WriteLine("Lista generata: " + string.Join(", ", numeri));

            Console.Write("\nInserisci numero da cercare: ");
        int ricerca = int.Parse(Console.ReadLine());

        int indice = numeri.IndexOf(ricerca);

        if (indice != -1)
            {
            Console.WriteLine($"Il numero {ricerca} è presente all'indice {indice}.");
            }
        else
        {
            Console.WriteLine("Il numero non è presente nella lista.");
        }

        List<int> pari = new List<int>();
        foreach (int n in numeri)
        {
            if (n % 2 == 0) 
            {
            pari.Add(n);
            }
}

            Console.WriteLine($"\nSono presenti {pari.Count} numeri pari.");


            Console.WriteLine("I numeri pari sono: " + string.Join(", ", pari));


        //esercizio list 3

        Random random = new Random();
        List<int> numeri = new List<int>();

        for (int i = 0; i < 15; i++)
        {
            numeri.Add(random.Next(1, 21));
        }

        Console.WriteLine("numeri: " + string.Join(", ", numeri));

        List<int> list = new List<int>();

        foreach (int n in numeri)
        {
            if (list.Contains(n))
            {
                // se contiente gia il numero non fa niente (controllo duplicati)
            }
            else
            {
                list.Add(n);
            }
        }

        list.Sort();
        Console.WriteLine("numeri in ordine: " + string.Join(", ", list));

    }

}