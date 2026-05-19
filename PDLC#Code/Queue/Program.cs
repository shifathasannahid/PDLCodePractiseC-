
using System;

Queue<int> queue  = new Queue<int>();

//Enqueue Data
queue.Enqueue(5);
queue.Enqueue(10);
queue.Enqueue(15);
queue.Enqueue(20);

foreach(int item in queue)
{
    Console.WriteLine("Enque Data: "+item);
}

Console.WriteLine();

//Dequeue Data
int first = queue.Dequeue();
Console.WriteLine("Dequeue data: " + first);

//Top e kon data ase
int top = queue.Peek();
Console.WriteLine("Top data:" + top);

foreach(var item in queue)
{
    Console.WriteLine("Remind data: " + item);
}


