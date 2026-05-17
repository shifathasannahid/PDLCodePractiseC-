using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesmodifier;

public class Person
{
    //Public Access Modifier
    public string Name;

    public void DisplayPublic()
    {
        Console.WriteLine("Public Access Modifier: " + Name);
    }

    //Private Access Modifier
    private int age;

    public void SetAge(int age)
    {
        this.age = age;
    }

    public void DisplayPrivate()
    {
        Console.WriteLine("Private Access Modifier: " + age);
    }

    //protected Access Modifier
    protected string Address;

    protected void showAddress()
    {
        Console.WriteLine("Protected Access Modifier: " + Address);
    }

}

