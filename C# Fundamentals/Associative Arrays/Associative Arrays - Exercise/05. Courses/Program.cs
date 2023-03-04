var dict = new Dictionary<string, List<string>>();

while (5 == 5)
{
    var input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "end")
    {
        break;
    }
    var course = input[0];
    var student = input[1];

    if (!dict.ContainsKey(course))
    {
        dict.Add(course, new List<string>());
        dict[course].Add(student);
    }
    else
    {
        dict[course].Add(student);
    }
}
foreach (var (key,value) in dict)
{
    Console.WriteLine($"{key}: {value.Count}");
    foreach (var item in dict[key])
    {
        Console.WriteLine($"-- {item}");
    }
}