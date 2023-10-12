namespace SOLID.D_violation;

public class NotificationWorker
{
    //din cauza ca depindem de clasa concreta,
    //dar nu de abstractizare, nu ne putem extinde
    private ConsoleNotifier _notifier;

    public NotificationWorker(ConsoleNotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.Notify(message);
    }
}