using System;

class Program
{
    static void Main()
    {
        ModuloA moduloA = new ModuloA();
        ModuloB moduloB = new ModuloB();

        moduloA.EsempioModulo1();

        moduloB.EsempioModulo2();

        ConfigurazioneSistema.Instance.StampaTutte();

        var istanza1 = ConfigurazioneSistema.Instance;
        var istanza2 = ConfigurazioneSistema.Instance;

        if (Object.ReferenceEquals(istanza1, istanza2))
        {
            Console.WriteLine("L'istanza è uguale");
        }
    }
}