using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returntype
{
    public class Calculator
    {
        //Return type int
        public int Add(int a , int b)
        {
            return a + b;
        }

        //Return type double
        public double Multiply(double a, double b)
        {
            return a * b;
        }


        //Return type string
        public string Name()
        {
            return "Calculator";
        }

        //Return type void
        public void Display()
        {
            Console.WriteLine("Simple Calculator With Return Types");
        }
    }
}
