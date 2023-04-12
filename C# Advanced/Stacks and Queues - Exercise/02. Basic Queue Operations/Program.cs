var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var toAdd = input[0];
var toPop = input[1];
var toCheck = input[2];
var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(nums);
for (int i = 0; i < toPop; i++)
{
    if (queue.Count == 0)
    {
        Console.WriteLine(0);
        return;
    }
    queue.Dequeue();
}
if (queue.Count > 0)
{
    if (queue.Contains(toCheck))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(queue.Min());
    }
}
else
{
    Console.WriteLine(0);
}