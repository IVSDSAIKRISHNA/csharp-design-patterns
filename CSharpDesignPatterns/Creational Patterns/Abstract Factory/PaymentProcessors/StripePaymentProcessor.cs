using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentProcessors;

public class StripePaymentProcessor : IPaymentProcessor
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Stripe Payment of {amount} is Processed");
    }
}
