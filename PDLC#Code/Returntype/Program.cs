using PropertyMethod;
using Returntype;

Calculator cal = new Calculator();

int sum = cal.Add(5, 10);

double multiple = cal.Multiply(3.5, 2.0);

string name = cal.Name();

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Multiple: " + multiple);
Console.WriteLine("Name: " + name);

cal.Display();


//Employee er Address 
Employee employee = new Employee();
employee.Show();