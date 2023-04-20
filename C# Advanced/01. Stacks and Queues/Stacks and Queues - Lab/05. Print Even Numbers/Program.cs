var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
Queue<int> queue = new Queue<int>();
foreach (var item in input)
{
    if (item % 2 == 0)
    {
        queue.Enqueue(item);
    }
}
Console.WriteLine(String.Join(", ",queue));