Queue<int> cups = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
Stack<int> bottles = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
var wastedL = 0;
var usedBottles = 0;
while (cups.Count > 0 && bottles.Count > 0)
{
    var currentCup = cups.Peek();
    while (currentCup > 0 && bottles.Count>0)
    {
        var currentBottle = bottles.Pop();
        usedBottles++;
        currentCup -= currentBottle;
        if (currentCup <= 0)
        {
            cups.Dequeue();
            wastedL += Math.Abs(currentCup);
            break;
        }
    }
}
if (!cups.Any())
{
    Console.WriteLine($"Bottles: {String.Join(" ",bottles)}");
}
else
{
    Console.WriteLine($"Cups: {String.Join(" ", cups)}");
}
Console.WriteLine($"Wasted litters of water: {wastedL}");