var first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var second = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
while (first.Count > 0 && second.Count > 0)
{
    if (first[0] > second[0])
    {
        first.Add(first[0]);
        first.Add(second[0]);
        second.RemoveAt(0);
        first.RemoveAt(0);
    }else if (first[0] < second[0])
    {
        second.Add(second[0]);
        second.Add(first[0]);
        first.RemoveAt(0);
        second.RemoveAt(0);
    }
    else
    {
        first.RemoveAt(0);
        second.RemoveAt(0);
    }
}
if(first.Count == 0)
{
    Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
}
else
{
    Console.WriteLine($"First player wins! Sum: {first.Sum()}");
}