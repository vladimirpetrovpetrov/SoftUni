namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        Rectangle circle = new Rectangle(5,5);
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine(circle.Draw());
    }
}