var input = Console.ReadLine();
Dictionary<char,int> result = new Dictionary<char,int>();
for (int i = 0; i < input.Length; i++)
{
    if (!result.ContainsKey(input[i]))
    {
        result[input[i]] = 1;
        continue;
    }
    result[input[i]]++;
}
foreach (var (k,v) in result.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{k}: {v} time/s");
}