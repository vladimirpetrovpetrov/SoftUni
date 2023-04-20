var kidNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
var n = int.Parse(Console.ReadLine()!);
Queue<string> kids = new Queue<string>(kidNames);
while(kids.Count > 1)
{
	for (int i = 1; i < n; i++)
	{
		var kidWithPotato = kids.Dequeue();
		kids.Enqueue(kidWithPotato);
	}
	Console.WriteLine($"Removed {kids.Dequeue()}");
}
Console.WriteLine($"Last is {kids.Dequeue()}");