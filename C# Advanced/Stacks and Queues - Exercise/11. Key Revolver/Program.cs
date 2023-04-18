int bulletPrice = int.Parse(Console.ReadLine());
int sizeOfBarrel = int.Parse(Console.ReadLine());
var bulletsInput = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
Stack<int> bullets = new(bulletsInput);
var locksInput = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
Queue<int> locks = new(locksInput);
var prize = int.Parse(Console.ReadLine());
var currentRound = 0;
var noBullets = false;
var noLocks = false;
var bulletsFired = 0;
while(bullets.Count > 0 && locks.Count > 0)
{
    var bullet = bullets.Pop();
    bulletsFired++;
    if (bullet <= locks.Peek())
    {
        Console.WriteLine("Bang!");
        locks.Dequeue();
    }
    else
    {
        Console.WriteLine("Ping!");
    }
    currentRound++;
    if (currentRound>= sizeOfBarrel && bullets.Count>0)
    {
        Console.WriteLine("Reloading!");
        currentRound = 0;
    }
}
prize -= bulletsFired * bulletPrice;
if (!locks.Any())
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${prize}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}