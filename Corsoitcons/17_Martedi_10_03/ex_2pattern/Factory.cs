public class DispositivoFactory
{
    public static IDispositivo CreaDispositivo(string tipo)
    {
        tipo = tipo.ToLower();

        if (tipo == "computer")
        {
            return new Computer();
        }
        else if (tipo == "stampante")
        {
            return new Stampante();
        }
        
        return null;
    }
}