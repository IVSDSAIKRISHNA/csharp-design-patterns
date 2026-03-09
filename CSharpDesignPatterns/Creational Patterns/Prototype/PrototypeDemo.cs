using CSharpDesignPatterns.Creational_Patterns.Prototype.Models;

namespace CSharpDesignPatterns.Creational_Patterns.Prototype;

public static class PrototypeDemo_
{
    public static void TestPrototypePattern()
    {
        var template = new Document
        {
            Title = "Invoice Template",
            Author = new Author { Name = "Finance Dept" },
            Metadata = new Metadata { CreatedDate = DateTime.Now }
        };

        var shallowCopy = template.ShallowClone();

        shallowCopy.Title = "Invoice #101";
        shallowCopy.Author!.Name = "Accounts Team";

        Console.WriteLine("Original Document:");
        template.Print();

        Console.WriteLine("Shallow Clone:");
        shallowCopy.Print();


        var deepCopy = template.DeepClone();

        deepCopy.Title = "Invoice #202";
        deepCopy.Author!.Name = "Billing Team";

        Console.WriteLine("Original Document:");
        template.Print();

        Console.WriteLine("Deep Clone:");
        deepCopy.Print();
    }
}
