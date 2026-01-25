namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentProcessors;

public class PayPalPaymentProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"PayPal Payment of {amount} is Processed");
    }
}
