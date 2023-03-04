namespace _01.Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var dict = new SortedDictionary<int, int>();
            //key - the number
            //vlaue - times it occurs 
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num] += 1;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }




        }
    }
}