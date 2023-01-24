var n = int.Parse(Console.ReadLine());
int number = 1;
int result = 0;
while (n > 0)
{
    result += number;
    Console.WriteLine(number);
    number += 2;
    n--;
}
Console.WriteLine($"Sum: {result}");