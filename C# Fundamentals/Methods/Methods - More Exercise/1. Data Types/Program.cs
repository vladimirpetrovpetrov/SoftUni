public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "int")
        {
            var x = int.Parse(Console.ReadLine());
            Print(x);
        }
        else if (input == "real")
        {
            var x = double.Parse(Console.ReadLine());
            Print(x);
        }
        else if (input == "string")
        {
            var x = Console.ReadLine();
            Print(x);
        }
    }
    static void Print(int a)
    {
        Console.WriteLine(a * 2);
    }
    static void Print(double a)
    {
        Console.WriteLine($"{(a * 1.5):f2}");
    }
    static void Print(string a)
    {
        Console.WriteLine($"${a}$");
    }

}