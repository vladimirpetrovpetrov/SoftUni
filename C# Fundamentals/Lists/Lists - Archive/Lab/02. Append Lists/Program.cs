using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            var x = new List<string>();
            var y = new List<string>();
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                x = list[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                y.AddRange(x);
            }
            Console.WriteLine(String.Join(" ", y));
        }
    }
}
