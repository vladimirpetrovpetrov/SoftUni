namespace _01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> PrintOnNewRow = x => Console.WriteLine(x);
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(PrintOnNewRow);
        }
    }
}