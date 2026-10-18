namespace CSharpDesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        /*FactoryPaternDemo.TestFactoryPattern();*/
        /*AbstractFactoryDemo.TestAbstractFactoryPattern();*/
        /*SingletonDemo.TestSingleton();*/
        /*ObserverDemo.TestObserver();*/
        //BuilderDemo.TestOrderBuilder();

        TemplateDemo.CalculateStandardCharges(100);
        TemplateDemo.CalculatePremiumCharges(100);
    }
}
