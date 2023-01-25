var numberOfChars = int.Parse(Console.ReadLine());
var sum = 0;
for (int i = 0; i < numberOfChars; i++)
{
    var n = char.Parse(Console.ReadLine());

    sum += n;
}
Console.WriteLine($"The sum equals: {sum}");