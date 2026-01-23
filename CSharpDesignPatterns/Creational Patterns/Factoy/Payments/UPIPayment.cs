namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class UPIPayment : IPaymentMethod
{
    // Method Which Processes the Credit Card Payment.
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing of {amount.ToString("C")} is Successfull. Thank You  Boss");
    }
}
