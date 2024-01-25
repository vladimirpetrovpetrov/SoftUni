using System;

namespace _011.Find_seq_in_array_that_has_a_sum_of_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 11;
            int[] numbers = { 4, 3, 1, 4, 1, 5, 8 };
            var sum = 0;
            var bestIndex = 0;
            var count = 1;
            var bestCount = 1;
           
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                sum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                    count++;
                    if (sum > n)
                    {
                        break;
                    }
                    else if (sum == n)
                    {
                        bestCount = count;
                        bestIndex = i;
                        int[] result = new int[count];
                        Array.Copy(numbers, bestIndex, result, 0, count);
                        Console.Write(String.Join(" + ",result));
                        Console.Write($" = {n}");
                        return;
                    }
                }
                count = 1;
                sum = 0;
            }
           






        }
    }
}
