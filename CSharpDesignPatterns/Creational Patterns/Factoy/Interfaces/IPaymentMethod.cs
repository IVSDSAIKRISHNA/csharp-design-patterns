using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}
