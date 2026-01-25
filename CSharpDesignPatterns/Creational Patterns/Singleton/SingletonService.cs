namespace CSharpDesignPatterns.Creational_Patterns.Singleton;

// Singleton Service.
public class SingletonService
{
    // Lazy<T> creates instance only when it is accessed and it is thread safe as it uses lock internally.
    private static readonly Lazy<SingletonService> instance= new Lazy<SingletonService>(()=> new SingletonService());

    // Private Constructor to Ensure that no one can create a new instance using the "new" keyword.
    private SingletonService()
    {
    }

    // The public Instace which every one accesses, it provides encapsulation.
    public static SingletonService Instance
    {
        get
        {
            return instance.Value ;   
        }
    }

}
