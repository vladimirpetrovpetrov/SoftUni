using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _04._Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var separators = new char[] { ' ', ',', '.', '?', '!' };
            var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            
            foreach (var word in words)
            {
                bool isPal = true;
                if (word.Length == 1)
                {
                    palindromes.Add(word);
                }
                for (int i = 0; i < word.Length/2; i++)
                {
                    if (!(word[i] == word[word.Length - 1 - i]))
                    {
                        isPal = false;
                        break;
                    }
                }
                if (isPal)
                {
                    palindromes.Add(word);
                }
            }
            palindromes  = palindromes.OrderBy(x=>x).ToList();
            var result = new HashSet<string>();
            result = palindromes.ToHashSet();
            Console.WriteLine(String.Join(", ",result));


        }
    }
}
