using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            input = input.OrderByDescending(x => x).ToList();
            
            if (input.Count >= 3)
            {
                Console.WriteLine(String.Join(" ",input.Take(3)));
            }
            else
            {
                Console.WriteLine(String.Join(" ",input));
            }






        }
    }
}
