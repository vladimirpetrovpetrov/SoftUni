using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            double avrg = nums.Average();
            List<int> greater = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > avrg)
                {
                    greater.Add(nums[i]);
                }
            }
            greater = greater.OrderByDescending(x => x).ToList();
            if (greater.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if (greater.Count > 0 && greater.Count < 5)
            {
                Console.WriteLine(String.Join(" ", greater));
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(greater[i] + " ");
                }
            }
        }
    }
}
