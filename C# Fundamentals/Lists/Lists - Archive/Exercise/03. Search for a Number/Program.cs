using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            var array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            list = list.Take(array[0]).ToList();
            list = list.Skip(array[1]).ToList();
            if (list.Contains(array[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
