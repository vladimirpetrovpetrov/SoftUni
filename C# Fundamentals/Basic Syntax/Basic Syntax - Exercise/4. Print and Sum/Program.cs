var start = int.Parse(Console.ReadLine());
var end = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = start; i <= end; i++)
{
    sum += i;
    if (i == end)
    {
        Console.Write(i);
        break;
    }
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");