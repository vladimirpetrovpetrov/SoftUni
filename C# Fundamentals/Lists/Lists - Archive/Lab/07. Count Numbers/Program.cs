var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

var distinctList = numbers.Distinct().OrderBy(x=>x).ToList();

for (int i = 0; i < distinctList.Count; i++)
{
	int count = 0;
	for (int j = 0; j < numbers.Count; j++)
	{
		if (distinctList[i] == numbers[j])
		{
			count++;
		}
	}
	Console.WriteLine($"{distinctList[i]} -> {count}");
}