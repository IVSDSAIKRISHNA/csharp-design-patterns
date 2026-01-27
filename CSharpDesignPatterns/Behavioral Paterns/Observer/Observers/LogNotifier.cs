namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

public class LogNotifier : IObserver
{
    public void Notify(string orderId)
    {
        Console.WriteLine($" Logs: Order Places with OrderId {orderId}");
    }
}
