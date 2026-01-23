namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class FactoryPaternDemo
{
    //Method To Test Factory Pattern.
    public static void TestFactoryPattern()
    {
        var processor= new CreditCardProcessor();
        processor.Process(500);
    }
}
