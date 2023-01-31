var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
var sum = int.Parse(Console.ReadLine());


for (int i = 0;i < arr.Length; i++)
{
	for (int j = i+1; j < arr.Length; j++)
	{

		if (arr[i] + arr[j] == sum)
		{
			Console.WriteLine($"{arr[i]} {arr[j]}");
		}
	}
}
