//Dictionary<keyType, ValueType>

Dictionary<string, int> marks = new Dictionary<string, int>();

//Adding
marks.Add("Shifat", 90);
marks.Add("Nahid", 87);
marks.Add("Jamil", 92);

//Value Read 
Console.WriteLine(marks["Shifat"]);

//Update
marks["Jamil"] = 94;

//Remove
marks.Remove("Nahid");

//All data show
foreach (var mark in marks)
{
    Console.WriteLine(mark.Key + "-->"+ mark.Value);
}

//Key searching
if (marks.ContainsKey("Shifat"))
{
    Console.WriteLine("Key ta holo " + marks["Shifat"]);
}
else
{
    Console.WriteLine("Key nei");
}