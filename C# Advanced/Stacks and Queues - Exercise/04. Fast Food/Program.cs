var quantity = int.Parse(Console.ReadLine());
var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>(input);
var fullfilled = new List<int>();
while (queue.Count > 0 && quantity >= 0)
{
    fullfilled.Add(queue.Peek());
    if(quantity-queue.Peek() < 0)
    {
        Console.WriteLine(fullfilled.Max());
        Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
        return;
    }
    quantity -= queue.Dequeue();
}
Console.WriteLine(fullfilled.Max());
Console.WriteLine("Orders complete");