double lengthFirstLine = 0;
double lengthSecondLine = 0;

double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
lengthFirstLine = CalculateD(x1, y1, x2, y2);

double z1 = double.Parse(Console.ReadLine());
double m1 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());
double m2 = double.Parse(Console.ReadLine());
lengthSecondLine = CalculateD(z1, m1, z2, m2);

if (lengthFirstLine < lengthSecondLine)
{
    double distanceToC1 = CalculateDistanceToCenter(z1, z2);
    double distanceToC2 = CalculateDistanceToCenter(m1, m2);

    if (distanceToC1 <= distanceToC2)
    {
        Console.WriteLine($"({z1}, {m1})({z2}, {m2})");
    }
    else
    {
        Console.WriteLine($"({z2}, {m2})({z1}, {m1})");
    }
}
else
{

    double distanceToC1 = CalculateDistanceToCenter(x1, x2);
    double distanceToC2 = CalculateDistanceToCenter(y1, y2);

    if (distanceToC1 <= distanceToC2)
    {
        Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
    }
    else
    {
        Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
    }
}
static double CalculateD(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(Math.Abs(x1 - y1), 2) + Math.Pow(Math.Abs(x2 - y2), 2));
}
static double CalculateDistanceToCenter(double x1, double x2)
{
    return Math.Sqrt(Math.Pow(Math.Abs(0 - x1), 2) + Math.Pow(Math.Abs(0 - x2), 2));
}