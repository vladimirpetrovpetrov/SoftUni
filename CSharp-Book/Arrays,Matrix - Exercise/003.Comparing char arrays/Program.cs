using System;
using System.Linq;

namespace Comparing_char_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] charArrayOne = { 'd', 'z', '2', 'e' };
            char[] charArrayTwo = { 'd', 'i', '1', 'e' };

            for (int i = 0; i < charArrayOne.Length; i++)
            {
                if (charArrayOne[i] > charArrayTwo[i])
                {
                    Console.WriteLine("Second array is sooner lexicographically.");
                    return;
                }
                else if (charArrayOne[i] < charArrayTwo[i])
                {
                    Console.WriteLine("First array is sooner lexicographically.");
                    return;
                }
            }
            Console.WriteLine("They are equal.");

        }
    }
}
