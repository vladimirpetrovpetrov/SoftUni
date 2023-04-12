var totalPumps = int.Parse(Console.ReadLine());
var totalDistance = 0;

Queue<int> pumps = new Queue<int>();
for (int i = 0; i < totalPumps; i++)
{
    //check if only ints or double also/check int or long
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    var litresOfThePump = input[0];
    var distanceToNext = input[1];
    totalDistance += distanceToNext;
    pumps.Enqueue(litresOfThePump);
}
var tankL = 0;
var count = -1;
while (pumps.Count != 0)
{
    tankL += pumps.Dequeue();
    count++;
    if (tankL >= totalDistance)
    {
        Console.WriteLine(count);
        break;
    }
}



//TODO 