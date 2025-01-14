
Console.WriteLine("Enter comma-seperated first names");
string data = Console.ReadLine();


//string data = "tim,sue,bob,jane";
List<string> firstNames = data.Split(',').ToList();
//foreach (string name in firstNames)

//for (int i = 0; i < firstNames.Count; i++)
//{
//    Console.WriteLine(firstNames[i]);
//}

foreach (string firstname in firstNames)
{
    Console.WriteLine(firstname);
}