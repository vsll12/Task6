Dictionary<int,string> dictionary1 = new Dictionary<int,string>();
dictionary1.Add(1, "Hello");
dictionary1.Add(2, "Name");

foreach (var dictionary2 in dictionary1)
{
    Console.WriteLine($"{dictionary2.Key} and {dictionary2.Value}");
}


//ContainsKey()

if (dictionary1.ContainsKey(1))
{
    Console.WriteLine(dictionary1[1]);
}

//TryGetValue()

if(dictionary1.TryGetValue(1,out string? result))
{
    Console.WriteLine(result);
}

//Update dictionary

dictionary1[0] =  "Helloo";

Console.WriteLine(dictionary1[0]);