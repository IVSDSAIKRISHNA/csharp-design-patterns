namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class CreditCardProcessor : PaymentProcessor
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new CreditCardPayment();
    }
}
