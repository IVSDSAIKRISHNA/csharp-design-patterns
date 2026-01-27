namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

// Observers.
public class EmailNotifier : IObserver
{
    public void Notify(string orderId)
    {
        Console.WriteLine($"  Email: Your Order with Order Id {orderId} is Successfully Placed");
    }
}
