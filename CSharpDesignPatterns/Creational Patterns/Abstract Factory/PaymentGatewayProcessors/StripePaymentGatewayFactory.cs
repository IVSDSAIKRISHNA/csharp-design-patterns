namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentGatewayProcessors;

//  Cocrete Implementation of Factory.
public class StripePaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new StripePaymentProcessor();
    }

    public IRefundProcessor CreateRefundProcessor()
    {
        return new StripeRefundProcessor();
    }
}
