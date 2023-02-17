using System;
using System.Linq;

namespace _05._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            numbers = numbers.OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(" <= ",numbers));
        }
    }
}
