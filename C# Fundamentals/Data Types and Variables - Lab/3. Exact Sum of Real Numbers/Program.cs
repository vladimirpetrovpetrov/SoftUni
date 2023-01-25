var n = int.Parse(Console.ReadLine());
var sum = 0m;
while (n > 0)
{
    decimal num = decimal.Parse(Console.ReadLine());
    sum += num;
    n--;
}
Console.WriteLine(sum);