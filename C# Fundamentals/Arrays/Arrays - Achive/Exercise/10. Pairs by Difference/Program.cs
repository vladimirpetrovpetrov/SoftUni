using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }
                    if (numbers[i] - numbers[j] == n)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
