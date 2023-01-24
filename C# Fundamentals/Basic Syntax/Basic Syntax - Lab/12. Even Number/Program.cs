var n = 1;

while(n%2 != 0)
{
    
    n = int.Parse(Console.ReadLine());
    if (n % 2 == 0)
    {
        Console.WriteLine($"The number is: {Math.Abs(n)}");
        return;
    }
    Console.WriteLine("Please write an even number.");
}