using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Short_Words_Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '\"', '\'', '\\', '/', '!', '?', ' ' };
            var input = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            ;
            input = input.Where(input=> input.Length < 5 ).OrderBy(x=>x).ToList();
            HashSet<string> noDuplicates = new HashSet<string>();
            noDuplicates = input.ToHashSet();

            Console.WriteLine(String.Join(", ",noDuplicates));






        }
    }
}
