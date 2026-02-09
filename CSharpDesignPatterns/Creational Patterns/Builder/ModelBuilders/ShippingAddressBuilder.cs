namespace CSharpDesignPatterns.Creational_Patterns.Builder.ModelBuilders;

public class ShippingAddressBuilder
{
    private string? _street { get; set; }
    private string? _city { get; set; }
    private string? _state { get; set; }
    private string? _country { get; set; }
    private int _postalCode { get; set; }

    private ShippingAddressBuilder() { }

    public static ShippingAddressBuilder Empty() => new();


    public ShippingAddressBuilder WithStreet( string street)
    {
        _state = street;
        return this;
    }
    public ShippingAddressBuilder WithCity(string city)
    {
        _city = city;
        return this;
    }
    public ShippingAddressBuilder WithState(string state)
    {
        _state = state;
        return this;
    }
    public ShippingAddressBuilder WithCountry(string Country)
    {
        _country = Country;
        return this;
    }

    public ShippingAddressBuilder WithPostalCode(int PostalCode)
    {
        _postalCode = PostalCode;
        return this;
    }

    public ShippingAddress Build()
    {
        return new ShippingAddress { Street = _street, City = _city, State = _state, PostalCode = _postalCode };
    }

}
