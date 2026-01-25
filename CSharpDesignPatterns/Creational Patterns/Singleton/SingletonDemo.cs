namespace CSharpDesignPatterns.Creational_Patterns.Singleton;

public static class SingletonDemo
{
    public static void TestSingleton()
    {
        Console.WriteLine(SingletonService.Instance.GetHashCode());
        Console.WriteLine(SingletonService.Instance.GetHashCode());
        Console.WriteLine(SingletonService.Instance.Equals(SingletonService.Instance));

    }
}
