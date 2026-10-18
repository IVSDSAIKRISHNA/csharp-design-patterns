namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method;

public static class TemplateDemo
{
    public static void CalculatePremiumCharges(int charges)
    {
        InvoiceProcessor premiumProcessor = new PremiumInvoiceProcessor();
        premiumProcessor.ProcessInvoice(charges);
    }

    public static void CalculateStandardCharges(int charges)
    {
        InvoiceProcessor standardProcessor = new StandardInvoiceProcessor();
        standardProcessor.ProcessInvoice(charges);
    }
}
