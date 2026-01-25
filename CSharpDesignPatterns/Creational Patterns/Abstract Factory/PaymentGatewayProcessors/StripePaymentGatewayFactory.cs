using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;
using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentProcessors;
using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Refund_Processors;

namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentGatewayProcessors;

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
