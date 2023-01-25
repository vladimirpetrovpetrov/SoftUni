var lines = int.Parse(Console.ReadLine());
int capacityOfTank = 255;



for(int i = 0;i < lines; i++)
{
    var line = int.Parse(Console.ReadLine());
    if (capacityOfTank >= line)
    {
        capacityOfTank -= line;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}
Console.WriteLine(255-capacityOfTank);