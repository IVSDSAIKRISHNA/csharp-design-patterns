namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Refund_Processors;

public class StripeRefundProcessor : IRefundProcessor
{
    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refund of amount {amount} is  Processed by Stripe");
    }
}
