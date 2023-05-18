int n = int.Parse(Console.ReadLine()!);
HashSet<string> uniqueNames = new();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    uniqueNames.Add(input!);
}
foreach (var item in uniqueNames)
{
    Console.WriteLine(item);
}