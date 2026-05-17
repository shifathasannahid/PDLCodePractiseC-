using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve
{
    public class Calculates : IShapes
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
           
            return a / b;
        }

        public int Modulus(int a, int b, string op)
        {
            return a % b;
        }


        public void Display()
        {
            Console.WriteLine("Addition: " + Addition(10, 5));

            Console.WriteLine("Subtraction: " + Subtraction(20, 15));

            Console.WriteLine("Multiplication: " + Multiplication(12, 5));

            Console.WriteLine("Division: " + Division(30, 6));

            Console.WriteLine("Modulus: " + Modulus(10, 3, "%"));
        }

       
    }
}
