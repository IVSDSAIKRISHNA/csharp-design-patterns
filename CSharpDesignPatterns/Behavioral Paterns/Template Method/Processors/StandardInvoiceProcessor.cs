namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method.Processors;

public class StandardInvoiceProcessor : InvoiceProcessor
{
    protected override int CalculateCharges(int amount)
    {
        Console.WriteLine($"Applying The Standard Charges on Amount {amount}");
        return (int)(Math.Ceiling(amount * 0.05));
    }
}
