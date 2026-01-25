using CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Services;

public class CheckoutService
{
    private IPaymentProcessor _processor;
    private IRefundProcessor _refundProcessor;

    public CheckoutService(IPaymentGatewayFactory factory)
    {
        _processor=factory.CreatePaymentProcessor();
        _refundProcessor=factory.CreateRefundProcessor();
    }

    public void Pay( decimal amount)
    {
        _processor.Pay(amount);
    }

    public void Refund( decimal amount ) 
    {
        _refundProcessor.Refund(amount);
    }
}
