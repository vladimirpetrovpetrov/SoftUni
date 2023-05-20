var n = int.Parse(Console.ReadLine());
Dictionary<string,int> result = new Dictionary<string,int>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    if (!result.ContainsKey(input))
    {
        result[input] = 1;
        continue;
    }
    result[input]++;
}
foreach (var (k,v) in result)
{
    if (v % 2 == 0)
    {
        Console.WriteLine(k);
        break;
    }
}