namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class FactoryPaternDemo
{
    //Method To Test Factory Pattern.
    public static void TestFactoryPattern()
    {
        // Creating a new Credit Card Processor.
        var processor= new CreditCardProcessor();
        processor.Process(500);
    }
}
