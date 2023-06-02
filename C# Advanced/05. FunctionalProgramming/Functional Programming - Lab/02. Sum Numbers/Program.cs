namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();

            Action<int[]> countAndSum = x =>
            {
                Console.WriteLine(x.Count());
                Console.WriteLine(x.Sum());
            };
            countAndSum(array);
        }
    }
}