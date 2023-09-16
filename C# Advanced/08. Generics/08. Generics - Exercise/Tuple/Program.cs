namespace Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            CustomTuple<string, string> tuple = new($"{input[0]} {input[1]}", input[2]);

            Console.WriteLine(tuple);

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            CustomTuple<string, int> tuple2 = new(input[0], int.Parse(input[1]));
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            CustomTuple<int, double> tuple3 = new(int.Parse(input[0]), double.Parse(input[1]));
            Console.WriteLine(tuple3);
        }
    }
}