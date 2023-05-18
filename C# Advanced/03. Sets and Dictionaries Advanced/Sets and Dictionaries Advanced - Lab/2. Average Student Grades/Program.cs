int n = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> dict = new();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    var name = input[0];
    var grade = decimal.Parse(input[1]);

    if (!dict.ContainsKey(name))
    {
        var list = new List<decimal>() { grade };
        dict[name] = list;
    }
    else
    {
        dict[name].Add(grade);
    }
}
foreach (var student in dict)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>x.ToString("F2")))} (avg: {student.Value.Average():f2})");
}