using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    public class person
    {
        //Fields
        public string name;
        public int age;

        //Constructor
        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }



        //Method
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }


    }
}
