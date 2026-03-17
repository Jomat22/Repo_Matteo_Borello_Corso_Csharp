public class Printer
{
    public ILogger Logger { get; set; }

    public void Print(string text)
    {
        if (Logger == null)
        {
            System.Console.WriteLine("Errore: Nessun logger configurato!");
            return;
        }

        Logger.Log($"Stampa in corso: {text}");
    }
}