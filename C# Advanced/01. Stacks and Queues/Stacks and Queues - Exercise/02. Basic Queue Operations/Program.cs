var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var toAdd = input[0];
var toRemove = input[1];
var toCheck = input[2];
Queue<int> queue = new Queue<int>();
var numbers = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
for (int i = 0; i < toAdd; i++)
{
    queue.Enqueue(numbers[i]);
}
for (int i = 0; i < toRemove; i++)
{
    queue.Dequeue();
}
bool isTrue = queue.Contains(toCheck);
if (queue.Count() > 0)
{
    if (isTrue)
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