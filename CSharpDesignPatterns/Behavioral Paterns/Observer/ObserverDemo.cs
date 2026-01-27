namespace CSharpDesignPatterns.Behavioral_Paterns.Observer;

public class ObserverDemo
{
    public static void TestObserver()
    {
        OrderService orderService = new OrderService();
        orderService.Attach(new EmailNotifier());
        orderService.Attach(new SMSNotifier());
        orderService.Attach(new LogNotifier());

        orderService.PlaceOrder("12345");
    }
}
