using System;
using System.Linq;

namespace _01.Sort_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).OrderBy(x=>x).ToList();
            Console.WriteLine(String.Join(", ",input));
        }
    }
}
