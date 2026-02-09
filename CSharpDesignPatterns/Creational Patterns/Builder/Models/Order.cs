namespace CSharpDesignPatterns.Creational_Patterns.Builder;

public class Order
{
    public int Number { get; set; }

    public required string Name { get; set; }

    public DateTime CreatedOn { get; set; }
}