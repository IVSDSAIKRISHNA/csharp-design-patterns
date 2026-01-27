namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

public class SMSNotifier : IObserver
{
    public void Notify(string orderId)
    {
        Console.WriteLine($"SMS: Thank You for placing the order.  Your Order Id is {orderId}, Please use this for tracking.");
    }
}
