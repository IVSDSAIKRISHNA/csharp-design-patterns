namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

// Observer.
public class LogNotifier : IObserver
{
    // Our Observer Specific logic goes here. 
    public void Notify(string orderId)
    {
        Console.WriteLine($" Logs: Order Places with OrderId {orderId}");
    }
}
