namespace Services.Interfaces
{
    public interface INotificationService
    {
        string Send(string text, string emailAddress);
    }
}
