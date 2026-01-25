using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.PaymentGatewayProcessors;
using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Services;

namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory;

public class AbstractFactoryDemo
{
    public static void TestAbstractFactoryPattern()
    {
        var stripeGateway = new StripePaymentGatewayFactory();
        var stripeCheckoutService = new CheckoutService(stripeGateway);
        stripeCheckoutService.Pay(500);
        stripeCheckoutService.Refund(100);
    }
}
