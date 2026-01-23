using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Creational_Patterns.Factoy;

public class FactoryPaternDemo
{
    //Method To Test Factory Pattern.
    public static void TestFactoryPattern()
    {
        var processor= new CreditCardProcessor();
        processor.Process(500);
    }
}
