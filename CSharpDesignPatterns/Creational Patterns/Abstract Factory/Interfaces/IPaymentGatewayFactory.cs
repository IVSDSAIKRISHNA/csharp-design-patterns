namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

// Factory Interface.
public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IRefundProcessor CreateRefundProcessor();
}