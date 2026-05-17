using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolve
{
    public interface IShapes
    {
        int Addition(int a, int b);

        int Subtraction(int a, int b);

        int Multiplication(int a, int b);

        int Division(int a, int b);

        int Modulus(int a, int b,string op);
        void Display();
    }
}
