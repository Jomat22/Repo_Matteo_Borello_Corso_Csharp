
// See https://aka.ms/new-console-template for more information
/*
using System;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
// commento a singola linea

/* commento a più 
linee
    */
class Program
{
    const float PI_NUMBER = 3.1415925359f; 
    public static readonly string Nome = "Franco";
    static void Main(string[] args){
    

Console.WriteLine("Hello, World!");


int contatore;   //dichiarazione
contatore = 0;  //assegnazione
int somma = 10;  //dichiarazione + inizializzazione
var nome ="Ada";  //tipo dedotto dal compilatore ("inferenza") 

// Implicito (safe, nessuna perdita di dati)
int intero = 42;
float numeroLungo = intero; // widening - da più piccolo a più grande

// Esplicito (potenziale perdita / eccezione)
float pi = 3.14f;
int circaPi = (int)pi; // narrowing - dal più grande al più piccolo

Console.WriteLine(contatore);
Console.WriteLine(0);
Console.WriteLine(somma);
Console.WriteLine(nome);
Console.WriteLine("Ciao mi chiamo" +  Nome);
Console.WriteLine(PI_NUMBER);
Console.WriteLine(numeroLungo);
Console.WriteLine(circaPi);

Console.WriteLine("Come ti chiami");
string nome2 = Console.ReadLine();
Console.WriteLine($"Ciao {nome2}!");

Console.Write("Dammi un numero?");
string n1 = Console.ReadLine();
Console.Write("Dammi un altro numero?");
string n2 = Console.ReadLine();

int numero1 = int.Parse(n1); //Conversione da string a int
int numero2 = int.Parse(n2);

Console.WriteLine($"Somma {numero1 + numero2}!");

int a = 10;
int b = 2;

Console.WriteLine("operatori aritmetici:");
Console.WriteLine($"a = {a}, b = {b}");
Console.WriteLine($"Addizione: a + b ={a + b}");
Console.WriteLine($"Sottrazione: a - b ={a - b}");
Console.WriteLine($"Moltiplicazione: a * b = {a * b}");
Console.WriteLine($"Divisione: a / b = {a / b}");
Console.WriteLine($"Modulo (resto): a % b ={a % b}");
Console.WriteLine($"Operatori Assegnamento:");
Console.WriteLine($"Incremento: a++ = {a++}"); //stampa a, poi incrementa di 1
Console.WriteLine($"Ora a = {a}");
Console.WriteLine($"Decremento: --b = {--b}"); // stampa b, poi decrementa di 1
Console.WriteLine($"Ora b = {b}");


Console.WriteLine("Operatori Logici:");
Console.WriteLine($"AND: {a < b && a >= 10}"); //True
Console.WriteLine($"OR: {a > b || a >= 10}"); //True
Console.WriteLine($"NOT: {!(a < b)}");        //False


    }
}