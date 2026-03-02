using System;

// 1. Classe Base
public class Animale
{
    // Usiamo 'virtual' per permettere alle classi figlie di modificarlo
    public virtual void Verso()
    {
        Console.WriteLine("L'animale emette un verso");
    }

    public void FaiVerso() 
    {
        Console.WriteLine("L'animale fa un verso generico.");
    }

    protected int eta;
}

// 2. Classe Derivata (Cane)
public class Cane : Animale
{
    // Usiamo 'override' per cambiare il comportamento di Verso()
    public override void Verso()
    {
        base.Verso();
        Console.WriteLine("Il cane abbaia");
    }

    public void Scodinzola()
    {
        Console.WriteLine("Il cane scodinzola.");
    }
}

// 3. Classe Derivata con 'new' (Leone)
public class Leone : Animale
{
    // 'new' nasconde il metodo della base invece di sovrascriverlo
    public new void Verso()
    {
        Console.WriteLine("Il leone ruggisce");
    }
}

//metodo sealed
public sealed class uccello
{
    //implementazione della classe
}

public class elefante : Animale
{
    public void impostaeta(int nuovaeta)
    {
        eta = nuovaeta; //accesso consentito grazie a protected
    }

        
    
}

// 4. Programma Principale
public class Programma
{
    public static void Main()
    {
        Cane mioCane = new Cane();
        mioCane.Verso(); 

        Leone mioLeone = new Leone();
        mioLeone.Verso();
    }
}