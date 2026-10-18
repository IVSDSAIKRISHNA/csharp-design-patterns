namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method;

public static class TemplateDemo
{
    public static void CalculatePremiumCharges(int billID)
    {
        InvoiceProcessor premiumProcessor = new PremiumInvoiceProcessor();
        premiumProcessor.ProcessInvoice(billID);
    }

    public static void CalculateStandardCharges(int billID)
    {
        InvoiceProcessor standardProcessor = new StandardInvoiceProcessor();
        standardProcessor.ProcessInvoice(billID);
    }
}
