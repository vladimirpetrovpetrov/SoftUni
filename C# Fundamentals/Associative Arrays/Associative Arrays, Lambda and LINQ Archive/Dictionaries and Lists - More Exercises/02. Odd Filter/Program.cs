using System;
using System.Linq;
namespace _02._Odd_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).ToList();
            var result = input.Select(x=> (x>input.Average()) ? x+1 : x-1).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
