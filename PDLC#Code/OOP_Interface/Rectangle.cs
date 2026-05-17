using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    public class Rectangle : Ishape
    {

        private double height;

        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double GetArea()
        {
            return height * width;
        }

        public void Display()
        {
            Console.WriteLine("Area of Rectangle: " + GetArea());
        }
    }
}
