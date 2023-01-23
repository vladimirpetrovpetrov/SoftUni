using System;
using System.Collections.Generic;

namespace _010.Мost_common_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 5, 1, 2, 4, 9, 3,4 };
            HashSet<int> set = new HashSet<int>();
            var count = 0;
            var bestCount = 0;
            var mostCommonNum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                set.Add(numbers[i]);
            }

            foreach (var item in set)
            {

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (item == numbers[i])
                    {
                        count++;
                        if (count > bestCount) 
                        {
                            bestCount = count;
                            mostCommonNum = item;
                        }
                    }
                    
                }
                count = 0;
            }
            Console.WriteLine($"Most common num({bestCount} times) is {mostCommonNum}");
        }
    }
}
