class Program {
    static void Main() {
        //Singleton
        RegistroOrdini registro = RegistroOrdini.GetIstanza();
        //Observer
        RepartoLaboratorio lab = new RepartoLaboratorio();
        
        registro.Iscrivi(lab);

        Console.Clear();
        Console.WriteLine(" Menù Torte");

        //Richiamo classe factory
        Console.WriteLine("Base: cioccolato, vaniglia, frutta?");
        string scelta = Console.ReadLine();
        ITorta miaTorta = TortaFactory.CreaTortaBase(scelta);

        if (miaTorta == null) {
            Console.WriteLine("Base non valida!");
            return;
        }

        // Decoratori
        bool continua = true;
        while (continua) {
            Console.WriteLine("\nExtra: 1.Panna | 2.Mirtilli | 3.Glassa | 0.Fine");
            string extra = Console.ReadLine();
            if (extra == "1") miaTorta = new ConPanna(miaTorta);
            else if (extra == "2") miaTorta = new ConMirtilli(miaTorta);
            else if (extra == "3") miaTorta = new ConGlassa(miaTorta);
            else if (extra == "0") continua = false;
        }

        Console.WriteLine("\nConferma ordine in corso...");
        //Salvataggio Singleton
        registro.Salva(miaTorta);
        
    }
}