using System;
using System.Linq;

namespace _008.Sorting_array_incr_decr_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elements of the array on one line with spaces: ");
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(array);
            Console.WriteLine("Sorted(increasing): ");
            Console.WriteLine(String.Join(", ",array));
            Array.Reverse(array);
            Console.WriteLine("Sorted(decreasing): ");
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
