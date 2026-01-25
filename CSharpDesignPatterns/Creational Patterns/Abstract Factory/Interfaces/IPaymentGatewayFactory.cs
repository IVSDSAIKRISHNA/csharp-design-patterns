namespace CSharpDesignPatterns.Creational_Patterns.Abstract_Factory.Interfaces;

public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IRefundProcessor CreateRefundProcessor();
}