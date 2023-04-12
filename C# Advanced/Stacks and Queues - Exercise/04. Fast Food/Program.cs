var quantity = int.Parse(Console.ReadLine());
var quantities = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var queue = new Queue<int>(quantities);
Console.WriteLine(queue.Max());
bool haveEnough = true;
while(queue.Count > 0)
{
    if (quantity >= queue.Peek())
    {
        quantity -= queue.Dequeue();
    }
    else
    {
        haveEnough = false;
        break;
    }
}
if (!haveEnough)
{
    Console.WriteLine($"Orders left: {String.Join(" ",queue)}");
}
else
{
    Console.WriteLine("Orders complete");
}