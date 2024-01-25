using System;

namespace _007.Find_K_elements_with_max_sum_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6,1,2,3,99,33 };
            var k = 3;
            var sum = 0;
            var bestSum = int.MinValue;

            for (int i = 0; i <= array.Length-k; i++)
            {
                for (int index = i; index < i+k; index++)
                {
                    sum += array[index];
                    if(sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
                sum = 0;
            }
            Console.WriteLine(bestSum);













        }
    }
}
