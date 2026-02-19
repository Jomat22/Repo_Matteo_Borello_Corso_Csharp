using System;

class escomplesso
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Inserisci nome");
        string nome = Console.ReadLine();
        Console.WriteLine("inserisci nuova password");
        string newPass = Console.ReadLine();

        bool continua = true;
        while (continua)
        {
            Console.WriteLine("1.esegui login \n 2.esci");
            string opzione = Console.ReadLine();

            switch (opzione)
            {
                case "1":
                Console.WriteLine("nome: ");
                string nomelogin = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();

                if (nomelogin == nome && pass == newPass)
                    {
                        Console.WriteLine("Accesso consentito");
                        for (int i = 10; i >= 0; i--)
                        {
                            Console.WriteLine(i + "...");

                        }
                    }
                    else
                    Console.WriteLine("Accesso non consentito");
                    break;

                    case "2":
                    continua = false;
                    break;
            }
        }
    }
}