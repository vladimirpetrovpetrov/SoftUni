using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Security;

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
            var currentBestIndex = 0;
            var bestCount = 1;

            for (int i = 1; i < length; i++)
            {
                if (currentNum < array[i])
                {
                    count++;
                    currentNum = array[i];
                    if (count > bestCount)
                    {
                        bestCount = count;
                        currentBestIndex = i + 1 - count;
                    }
                }
                else
                {
                    currentNum = array[i];
                    count = 1;
                }
            }

            for (int i = currentBestIndex; i < currentBestIndex + bestCount; i++)
            {
                Console.Write(array[i] + " ");
            }





        }
    }
}
