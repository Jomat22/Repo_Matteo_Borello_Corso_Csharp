interface IObserver
{
    void NotificaCreazione(string nomeUtente);
}

interface ISoggetto
{
    void Registra(IObserver o);
    void Rimuovi(IObserver o);
    void Notifica(string nomeUtente);
}