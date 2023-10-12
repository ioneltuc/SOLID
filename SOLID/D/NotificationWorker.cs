namespace SOLID.D;

public class NotificationWorker
{
    private INotifier _notifier;

    public NotificationWorker(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Notify(string message)
    {
        _notifier.Notify(message);
    }
}