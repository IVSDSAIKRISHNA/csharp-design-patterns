namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method.Processors;

public class PremiumInvoiceProcessor : InvoiceProcessor
{
    /// <summary>
    /// Providing the Implementation for Calcualte Charges. 
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    protected override int CalculateCharges(int amount)
    {
        Console.WriteLine($"Calcualting the Premium Charges for {amount}");
        return (int)Math.Ceiling(amount *0.07);
    }

    /// <summary>
    ///  Overriding the Optional Hook/ Virtual Method in Concrete Class.
    /// </summary>
    /// <param name="billId"></param>
    /// <returns></returns>
    protected override bool Validation(int billId)
    {
        Console.WriteLine("Applying  Custom Premium Validation ");
        return true;
    }
}
