using System;
using System.Linq;

namespace _06._Square_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            numbers = numbers.FindAll(x => x / Math.Sqrt(x) == (int)Math.Sqrt(x)).OrderByDescending(x=>x).ToList();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
