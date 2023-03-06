internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        var dict = new SortedDictionary<double, int>();

        foreach (var item in input)
        {
            if (!dict.ContainsKey(item))
            {
                dict[item] = 1;
            }
            else
            {
                dict[item]++;
            }
        }

        foreach (var (key, value) in dict)
        {
            Console.WriteLine($"{key} -> {value}");

        }
    }
}