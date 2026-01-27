namespace CSharpDesignPatterns.Behavioral_Paterns.Observer.Interfaces;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string orderId);
}
