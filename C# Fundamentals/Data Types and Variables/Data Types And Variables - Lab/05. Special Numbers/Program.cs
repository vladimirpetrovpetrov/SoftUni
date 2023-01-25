using System.Diagnostics.CodeAnalysis;

var n = int.Parse(Console.ReadLine());

for(int i = 1;i <= n; i++)
{
    bool now = IsItSpecial(i);
    Console.WriteLine($"{i} -> {now}");
}
bool IsItSpecial(int i)
{
    var sum = 0;
    while (i > 0)
    {
        sum += i % 10;
        i /= 10;
    }


    return (sum == 7 || sum == 11 || sum ==5);
}