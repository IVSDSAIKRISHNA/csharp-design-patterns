namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Observers;

// Actual Subject Implementing the interface.
public class OrderService : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    // Method  which is responsible for sending the info to all the observers.
    public void Notify(string orderId)
    {
        foreach (var observer in _observers)
        {
            observer.Notify(orderId);
        }
    }

    //  Business Logic. Each Subject has its own business logic. 
    public void PlaceOrder(string orderId)
    {
        Console.WriteLine($"Order placed: {orderId}");
        Notify(orderId);
    }
}
