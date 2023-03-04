namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var dict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if(!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word] += 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    dict.Remove(item.Key);
                }
            }
            Console.WriteLine(String.Join(" ", dict.Keys));
        }
    }
}