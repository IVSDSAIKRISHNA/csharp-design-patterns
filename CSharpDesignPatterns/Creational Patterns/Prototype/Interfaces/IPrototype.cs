namespace CSharpDesignPatterns.Creational_Patterns.Prototype.Interfaces;

public interface IPrototype<T>
{
    T ShallowClone();
    T DeepClone();
}
