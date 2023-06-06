namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> PutSir = x =>
            {
                Console.WriteLine("Sir " + x);
            };
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(PutSir);
        }
    }
}