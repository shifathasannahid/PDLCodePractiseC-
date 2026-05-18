
using System.Collections;

ArrayList arrayList = new ArrayList();

//Adding element
arrayList.Add(12);
arrayList.Add("Shifat");
arrayList.Add(3.34);
arrayList.Add(true);

//Display element
foreach (var item in arrayList)
{
    Console.WriteLine("Element : "+ item);
}

//Remove element
arrayList.Remove("Shifat");

Console.WriteLine("\n After Remove: ");
foreach(var item in arrayList)
{
    Console.WriteLine("Element : " + item);
}