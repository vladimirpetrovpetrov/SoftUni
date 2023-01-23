using System;

namespace Max_sequence_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oldCount = 0;
            var count = 1;
            var startingIndex = 0;
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 4 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (count > oldCount)
                    {
                        oldCount = count;
                        startingIndex = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.Write("{ ");
            for (int i = startingIndex + 1; i <= startingIndex + oldCount; i++)
            {

                Console.Write($"{array[i]}, ");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.WriteLine($"Max seq numbers = {oldCount}");
        }
    }
}
