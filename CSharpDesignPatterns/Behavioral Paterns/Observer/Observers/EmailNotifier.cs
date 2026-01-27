namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

// Observer.
public class EmailNotifier : IObserver
{
    // Our Observer Specific logic goes here. 
    public void Notify(string orderId)
    {
        Console.WriteLine($" Email: Your Order with Order Id {orderId} is Successfully Placed");
    }
}
