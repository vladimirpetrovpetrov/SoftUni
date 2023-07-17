namespace Shapes;

public class StartUp
{
    static void Main(string[] args)
    {
        var radius = int.Parse(Console.ReadLine());
        IDrawable drawable = new Circle(radius);
        drawable.Draw();

        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        IDrawable drawable1 = new Rectangle(width, height);
        drawable1.Draw();
    }
}