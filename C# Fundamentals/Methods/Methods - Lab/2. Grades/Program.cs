var x = double.Parse(Console.ReadLine());
Evaluate(x);


static void Evaluate(double x)
{
    if (x>= 2.00 && x < 3)
    {
        Console.WriteLine("Fail");
    }else if (x >= 3 && x < 3.50)
    {
        Console.WriteLine("Poor");
    }
    else if (x >= 3.50 && x < 4.50)
    {
        Console.WriteLine("Good");
    }
    else if (x >= 4.50 && x < 5.50)
    {
        Console.WriteLine("Very good");
    }
    else if (x >= 5.50 && x <= 6.00)
    {
        Console.WriteLine("Excellent");
    }
}