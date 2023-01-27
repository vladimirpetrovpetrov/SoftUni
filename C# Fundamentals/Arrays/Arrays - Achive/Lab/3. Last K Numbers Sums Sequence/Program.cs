using System;

namespace _3._Last_K_Numbers_Sums_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            long steps = long.Parse(Console.ReadLine());

            //initializing the Array
            long[] sequence = new long[number];
            //first element always is 1
            sequence[0] = 1;

            for (long i = 1; i < number; i++)
            {
                long sum = 0, last = i - 1, toSteps = 1;

                while (last >= 0 && toSteps <= steps)
                {
                    sum += sequence[last--];
                    toSteps++;
                }

                sequence[i] = sum;
            }

            foreach (long value in sequence)
                Console.Write(value + " ");












        }
    }
}
