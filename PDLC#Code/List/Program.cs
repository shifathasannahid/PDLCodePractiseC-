List<int> number = new List<int> { 10, 20,  30};

//Add number
number.Add(40);
number.Add(50);

foreach (var item in number)
{
    Console.Write(" " + item);
}

Console.WriteLine();

//Remove number
number.Remove(30);
number.Remove(50);

foreach(var item in number)
{
    Console.Write(" "+item);
}

