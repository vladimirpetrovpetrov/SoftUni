using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 1;
                }
                else
                {
                    dict[item]++;
                }
            }

            foreach (var item in dict)
            {
                if (dict[item.Key] % 2 == 0)
                {
                    dict.Remove(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", dict.Keys));


        }
    }
}
