namespace _01._Sort_Even_Numbers;

internal class Program
{
    static void Main(string[] args)
    {
        var sortedEvenNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .Where(x => x % 2 == 0)
                .OrderBy(x => x);
        Console.WriteLine(String.Join(", ", sortedEvenNumbers));
    }
}