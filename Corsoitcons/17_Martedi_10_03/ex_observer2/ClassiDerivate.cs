using System;

public class MobileApp : INewsSubscriber
{
    public void Update(string news) => 
        Console.WriteLine($"Notification on mobile: {news}");
}

public class EmailClient : INewsSubscriber
{
    public void Update(string news) => 
        Console.WriteLine($"Email sent: {news}");
}