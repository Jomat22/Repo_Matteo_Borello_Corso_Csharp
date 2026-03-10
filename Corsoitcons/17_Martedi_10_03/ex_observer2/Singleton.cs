using System.Collections.Generic;

public class NewsAgency
{
    private static NewsAgency _instance;
    private List<INewsSubscriber> _subscribers = new List<INewsSubscriber>();
    private string _aggNews;

    private NewsAgency() { }

    public static NewsAgency Instance
    {
        get
        {
            if (_instance == null) _instance = new NewsAgency();
            return _instance;
        }
    }

    public string News
    {
        get => _aggNews;
        set
        {
            _aggNews = value;
            Notifica();
        }
    }

    public void Registra(INewsSubscriber subscriber) => _subscribers.Add(subscriber);

    private void Notifica()
    {
        foreach (var i in _subscribers)
        {
            i.Update(_aggNews);
        }
    }
}