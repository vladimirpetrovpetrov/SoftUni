using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            var first = words[0].ToCharArray();
            var second = words[1].ToCharArray();

            var list1 = new List<char>();
            var list2 = new List<char>();

            for (int i = 0; i < first.Length; i++)
            {
                if (!list1.Any(x => x == first[i]))
                {
                    list1.Add(first[i]);
                }
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (!list2.Any(x => x == second[i]))
                {
                    list2.Add(second[i]);
                }
            }
            if (list1.Count == list2.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
