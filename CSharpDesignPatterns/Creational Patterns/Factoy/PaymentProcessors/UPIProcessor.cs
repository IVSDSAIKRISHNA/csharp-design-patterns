namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class UPIProcessor : PaymentProcessor
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new UPIPayment();
    }
}
