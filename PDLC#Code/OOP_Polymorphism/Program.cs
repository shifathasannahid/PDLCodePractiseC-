using OOP_Polymorphism;

Method_Overload overloding = new Method_Overload();
int addition = overloding.add(10, 20);
double additionDouble = overloding.add(10.5, 20.5);

Console.WriteLine("Addition of integers: " + addition);
Console.WriteLine("Addition of doubles: " + additionDouble);
