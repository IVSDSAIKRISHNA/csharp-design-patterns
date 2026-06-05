using CSharpDesignPatterns.Creational_Patterns.Prototype.Interfaces;
using CSharpDesignPatterns.Creational_Patterns.Prototype.Models;

namespace CSharpDesignPatterns.Creational_Patterns.Prototype;

public class Document : IPrototype<Document>
{
    public string? Title { get; set; }
    public Author? Author { get; set; }
    public Metadata? Metadata { get; set; }

    // SHALLOW COPY
    public Document ShallowClone()
    {
        return (Document)this.MemberwiseClone();
    }

    // DEEP COPY
    public Document DeepClone()
    {
        return new Document
        {
            Title = this.Title,
            Author = new Author
            {
                Name = this.Author?.Name ?? "John Doe",
            },
            Metadata = new Metadata
            {
                CreatedDate = this.Metadata?.CreatedDate ?? DateTime.UtcNow,
            }
        };
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author!.Name}");
        Console.WriteLine($"Created: {Metadata?.CreatedDate ?? DateTime.UtcNow}");
        Console.WriteLine("-------------------");
    }
}