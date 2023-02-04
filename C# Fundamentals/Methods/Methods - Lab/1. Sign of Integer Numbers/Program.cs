int x = int.Parse(Console.ReadLine());
Console.WriteLine(SignOfInt(x));



static string SignOfInt(int x)
{
    if (x > 0)
    {
        return $"The number {x} is positive.";
    }
    else if (x < 0)
    {
        return $"The number {x} is negative.";
    }
    else
    {
        return $"The number {x} is zero.";
    }
}