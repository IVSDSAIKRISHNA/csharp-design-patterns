using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class UPIPayment : IPaymentMethod
{
    // Method Which Processes the Credit Card Payment.
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing of {amount.ToString("C")} is Successfull. Thank You  Boss");
    }
}
