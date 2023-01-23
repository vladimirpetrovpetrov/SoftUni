using System;
using System.Collections.Generic;

namespace Find_max_increasing_seq_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 4, 3, 2, 1, 2, 1, 3, 5, 6, 66 };
            var currentNum = array[0];
            var length = array.Length;
            var count = 1;
            
            var bestCount = 1;
            HashSet<int> bestSet = new HashSet<int>();

            for (int num = 0; num < length; num++)
            {
                currentNum = array[num];
                for (int j = 1; j < length; j++)
                {
                    if (currentNum < array[j])
                    {
                        bestSet.Add(currentNum);
                        count++;
                        currentNum = array[j];
                        if (count > bestCount)
                        {

                            bestSet.Add(array[j]);
                            bestCount = count;
                        }
                    }
                    //TODO

                }
                count = 0;
            }
            Console.WriteLine(bestCount);
            Console.Write(String.Join(", ", bestSet));




        }
    }
}
