var command = Console.ReadLine();
var x  = double.Parse(Console.ReadLine());
var y = double.Parse(Console.ReadLine());
Console.WriteLine(Calculate(x,y,command));
static double Calculate(double x,double y,string command)
{
    if(command == "add")
    {
        return x + y;
    }else if(command == "multiply")
    {
        return x * y;
    }
    else if (command == "subtract")
    {
        return x - y;
    }
    else if (command == "divide")
    {
        return x / y;
    }
    return 0;
}