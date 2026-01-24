namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

// Unifying Interface Which every Payment Method Should Implement.
public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}