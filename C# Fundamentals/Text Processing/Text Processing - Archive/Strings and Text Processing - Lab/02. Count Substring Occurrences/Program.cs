using System;

namespace _02._Count_Substring_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var searched = Console.ReadLine().ToLower();
            var count = 0;
            while (true)
            {
                int indexOf = input.IndexOf(searched);
                if (indexOf == -1)
                {
                    break;
                }
                count++;
                input = input.Substring(indexOf + 1);
            }
            Console.WriteLine(count); ;
        }
    }
}
