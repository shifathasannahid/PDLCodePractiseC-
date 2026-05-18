Stack<int> stack = new Stack<int>();

//Data push kora
stack.Push(5);
stack.Push(10);
stack.Push(15);
stack.Push(20);

foreach(var item in stack)
{
    Console.WriteLine("Push data "+item);
}
Console.WriteLine();

//Data Pop kora
int remove1 = stack.Pop();
Console.WriteLine("Remove data1: "+remove1);

int remove2 = stack.Pop();
Console.WriteLine("Remove data2: " + remove2);

//Top e kon data ase
int top = stack.Peek();
Console.WriteLine("Top data: " + top);

//Last All data show
Console.WriteLine();
foreach (var item in stack)
{
 Console.WriteLine("Remind data "+item);   
}