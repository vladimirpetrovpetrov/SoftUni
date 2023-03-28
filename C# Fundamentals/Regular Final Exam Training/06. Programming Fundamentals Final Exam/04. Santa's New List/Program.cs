var children = new Dictionary<string,int>();
var presents = new Dictionary<string,int>();
while (true)
{
    var input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "END")
    {
        break;
    }
    if (input[0] == "Remove")
    {
        if (children.ContainsKey(input[1]))
        {
            children.Remove(input[1]);
        }
        continue;
    }

    var child = input[0];
    var presentType = input[1];
    var presentCount = int.Parse(input[2]);
    if (children.ContainsKey(child))
    {
        children[child] += presentCount;
        if (presents.ContainsKey(presentType))
        {
            presents[presentType] += presentCount;
        }
        else
        {
            presents[presentType] = presentCount;
        }
    }
    else
    {
        children[child] = presentCount;
        if (presents.ContainsKey(presentType))
        {
            presents[presentType] += presentCount;
        }
        else
        {
            presents[presentType] = presentCount;
        }
    }
}
Console.WriteLine("Children:");
foreach (var (key,value) in children.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
    Console.WriteLine($"{key} -> {value}");
}
Console.WriteLine("Presents:");
foreach (var (key, value) in presents)
{
    Console.WriteLine($"{key} -> {value}");
}