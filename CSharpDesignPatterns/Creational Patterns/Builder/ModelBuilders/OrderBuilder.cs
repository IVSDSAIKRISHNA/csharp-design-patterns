namespace CSharpDesignPatterns.Creational_Patterns.Builder.ModelBuilders;

public class OrderBuilder
{
    private int _number { get; set; }

    private string? _name { get; set; }

    private DateTime _createdOn { get; set; }

    private ShippingAddressBuilder _shippingAddressBuilder { get; set; } = ShippingAddressBuilder.Empty();

    // Creating a new Order Builder.
    public static OrderBuilder Empty() => new();

    public OrderBuilder WithNumber(int Number)
    {
        _number = Number;
        return this;
    }

    public OrderBuilder WithName(string Name)
    {
        _name = Name;
        return this;
    }

    public OrderBuilder WithCreatonOn(DateTime dateTime)
    {
        _createdOn = dateTime;
        return this;
    }

    public OrderBuilder WithShippingAddress( Action<ShippingAddressBuilder> builderDelegate)
    {
        builderDelegate(_shippingAddressBuilder);
        return this;
    }

    public Order Build()
    {
        return new Order { Name = _name ?? "N/A", CreatedOn = _createdOn, Number = _number , ShippingAddress= _shippingAddressBuilder.Build()};
    }
}
