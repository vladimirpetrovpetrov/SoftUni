SortedSet<string> chemicalElements = new SortedSet<string>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
	for (int j = 0; j < input.Length; j++)
	{
		chemicalElements.Add(input[j]);
	}
}
Console.WriteLine(String.Join(" ",chemicalElements));