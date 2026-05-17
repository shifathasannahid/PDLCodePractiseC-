using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyMethod
{
    public class Person
    {
        //Field and Property
        private int age;
        public string name { get; set; }

        public int Age
        {
            get { return age; }

            set
            {
                if(value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }

        //Method
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }


    }
}
