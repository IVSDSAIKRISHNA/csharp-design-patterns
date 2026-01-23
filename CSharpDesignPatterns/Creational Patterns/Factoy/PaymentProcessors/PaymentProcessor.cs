using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public   abstract class PaymentProcessor
{
    public  abstract IPaymentMethod CreatePaymentMethod();

    public void Process(decimal amount)
    {
        IPaymentMethod paymentMethod = CreatePaymentMethod();
        paymentMethod.ProcessPayment(amount);
    }
}
