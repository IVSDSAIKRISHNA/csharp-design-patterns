using System;
namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

// Actual Factory Class
public   abstract class PaymentProcessor
{
    public  abstract IPaymentMethod CreatePaymentMethod();

    public void Process(decimal amount)
    {
        IPaymentMethod paymentMethod = CreatePaymentMethod();
        paymentMethod.ProcessPayment(amount);
    }
}
