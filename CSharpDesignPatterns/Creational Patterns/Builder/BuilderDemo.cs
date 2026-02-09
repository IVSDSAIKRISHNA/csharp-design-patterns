namespace CSharpDesignPatterns.Creational_Patterns.Builder;

public class BuilderDemo
{
    public static  void TestOrderBuilder()
    {
        var order = OrderBuilder.Empty()
            .WithNumber(1)
            .WithName("Idk")
            .WithCreatonOn(DateTime.UtcNow)
            .WithShippingAddress(_=>_.WithStreet("Wall Street").WithCity("Gotham").WithState("TriStateArea").WithCountry("Wakanda").WithPostalCode(404))
            .Build();
        Console.WriteLine($" Order with Order Name {order.Name} and order number {order.Number} is created on {order.CreatedOn} from {order.ShippingAddress!.State}");
    }
}
