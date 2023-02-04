var x = int.Parse(Console.ReadLine());

PrintTriangle(x);

static void PrintLowerPart(int x)
{
    for (int i = x - 1; i >= 1; i--)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

static void PrintUpperPart(int x)
{
    for (int i = 1; i <= x; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }
}

static void PrintTriangle(int x)
{
    PrintUpperPart(x);
    PrintLowerPart(x);
}