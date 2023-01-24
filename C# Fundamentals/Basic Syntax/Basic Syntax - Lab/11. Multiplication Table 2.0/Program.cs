var n = int.Parse(Console.ReadLine());

var m = int.Parse(Console.ReadLine());
if (m > 10)
{
    Console.WriteLine($"{n} X {m} = {n*m}");
    return;
}
for (int i = m; i <= 10; i++)
{
    Console.WriteLine($"{n} X {i} = {n * i}");
}