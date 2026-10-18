namespace CSharpDesignPatterns.Behavioral_Paterns.Template_Method.Processors;

/// <summary>
/// Base Class . Defines the Tempalte method 
/// </summary>
public abstract  class InvoiceProcessor
{
    //Template Method
    public void ProcessInvoice( int billId)
    {
        if (!Validation(billId))
        {
            Console.WriteLine("This is not a Valid Bill Id . Please Contact the Help Desk");
        }

        var amount = CalculateAmount(billId);
        var charges = CalculateCharges(amount);
        PrintInvoice(amount + charges);
    }


    /// <summary>
    /// Hook. We provide Default Implementation But Concrete classes can customize them
    /// </summary>
    /// <param name="billId"></param>
    /// <returns></returns>
    protected virtual bool Validation( int billId)
    {
        Console.WriteLine("Validating the Bill. This may take some time..");
        return true;
    }

    /// <summary>
    /// Invariant Steps of Algorithm.
    /// </summary>
    /// <param name="billId"></param>
    /// <returns></returns>
    protected int CalculateAmount( int billId ) 
    {
        Console.WriteLine("Calcualting the Amount...");
        return 1000;
    }

    /// <summary>
    /// Abstract Method which is compulsory for the Concrete Class to override and give its own implementation.
    /// </summary>
    /// <param name="amount"></param>
    /// <returns></returns>
    protected abstract int CalculateCharges(int amount);

    /// <summary>
    /// Invariant Steps of Algorithm. 
    /// </summary>
    /// <param name="amount"></param>
    protected void PrintInvoice( int amount ) 
    {
        Console.WriteLine($"Thank you for Shopping with us, your amount is {amount}");
    }
}
