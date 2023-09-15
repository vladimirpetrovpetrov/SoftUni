namespace GenericSwapMethodStrings;

public class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Box<string> box = new Box<string>();

        for (int i = 0; i < n; i++)
        {
            box.AddValue(Console.ReadLine());
        }
        var indexes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        box.Swap(indexes[0], indexes[1]);
        Console.WriteLine(box);

    }

    
}