using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;
using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentProcessors;
using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Refund_Processors;

namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentGatewayProcessors;

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
