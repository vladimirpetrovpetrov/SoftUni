using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();


            for (int i = 0; i < nums.Length; i++)
            {
                var num = Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {num}");
            }
        }
    }
}
