namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method.Processors;

public class StandardInvoiceProcessor : InvoiceProcessor
{

    /// <summary>
    /// Implementing the Calcualte Charges for the Standard Invoice.
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    protected override int CalculateCharges(int amount)
    {
        Console.WriteLine($"Applying The Standard Charges on Amount {amount}");
        return (int)(Math.Ceiling(amount * 0.05));
    }
}
