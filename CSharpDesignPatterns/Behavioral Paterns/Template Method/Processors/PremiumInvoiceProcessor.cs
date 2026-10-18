namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method.Processors;

public class PremiumInvoiceProcessor : InvoiceProcessor
{
    protected override int CalculateCharges(int amount)
    {
        Console.WriteLine($"Calcualting the Premium Charges for {amount}");
        return (int)Math.Ceiling(amount *0.07);
    }

    protected override bool Validation(int billId)
    {
        Console.WriteLine("Applying  Custom Premium Validation ");
        return true;
    }
}
