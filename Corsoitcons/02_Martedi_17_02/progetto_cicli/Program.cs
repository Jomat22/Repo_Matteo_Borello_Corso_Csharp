using System;
class provacicli
{
    static void Main(string[] args){


bool continua = true;
while (continua) //finché “continua” rimane true il codice viene ripetuto
{
Console.WriteLine("Ciclo in esecuzione");
continua2 = bool.Parse(Console.ReadLine());
}

int continua2 = 0;
while (continua2 < 10) //finché “continua” rimane true il codice viene ripetuto
{
Console.WriteLine("Ciclo in esecuzione");
continua2 +=1;
Console.WriteLine(continua2);
}

    }
    }
