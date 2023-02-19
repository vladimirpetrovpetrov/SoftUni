using System;
using System.Linq;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Random random = new Random();

            while(sentence.Count > 0)
            {
                var str = sentence[random.Next(0,sentence.Count)];
                var index = sentence.IndexOf(str);
                Console.WriteLine(str);
                sentence.RemoveAt(index);
            }
        }
    }
}
