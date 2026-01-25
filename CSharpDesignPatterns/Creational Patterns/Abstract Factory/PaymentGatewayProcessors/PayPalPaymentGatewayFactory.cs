namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentGatewayProcessors;

//  Cocrete Implementation of Factory.
public class PayPalPaymentGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor()
    {
        return new PayPalPaymentProcessor();
    }

    public IRefundProcessor CreateRefundProcessor()
    {
        return new PayPalRefundProcessor();
    }
}
