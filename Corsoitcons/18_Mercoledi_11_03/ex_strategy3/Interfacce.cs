// interfaccia base
public interface IPiatto
{
    string Descrizione();
}

//Interfaccia strategy

public interface IPreparazioneStrategia
{
    string Prepara (string nomePiatto);
}

//Interfaccia Observer
public interface IObserver{
    void Aggiorna(string messaggio);
}

public interface ISubject
{
    void Registra(IObserver observer);
    void Notifica(string messaggio);
}