var dict = new Dictionary<string, List<string>>();

while (true)
{
    var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "End")
    {
        break;
    }
    var companyName = input[0];
    var employeId = input[1];

    if (!dict.ContainsKey(companyName))
    {
        dict.Add(companyName, new List<string>());
    }

    var exist = dict[companyName].Any(x => x == employeId);
    if (!exist)
    {
        dict[companyName].Add(employeId);
    }
}
foreach (var (key, value) in dict)
{
    Console.WriteLine(key);
    foreach (var item in dict[key])
    {
        Console.WriteLine($"-- {item}");
    }
}