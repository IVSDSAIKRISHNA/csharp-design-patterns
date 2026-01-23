namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class CreditCardPayment : IPaymentMethod
{
    // Method Which Processes the Credit Card Payment.
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit Card Payment of {amount} is processed");
    }
}
