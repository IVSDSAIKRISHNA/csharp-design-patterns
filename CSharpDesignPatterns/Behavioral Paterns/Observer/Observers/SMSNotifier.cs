namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

// Observer.
public class SMSNotifier : IObserver
{
    // Our Observer Specific logic goes here. 
    public void Notify(string orderId)
    {
        Console.WriteLine($"SMS: Thank You for placing the order.  Your Order Id is {orderId}, Please use this for tracking.");
    }
}
