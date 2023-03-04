namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var item in input[i])
                {
                    if (!dict.ContainsKey(item))
                    {
                        dict.Add(item, 0);
                    }
                    dict[item]++;
                }
            }
            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}