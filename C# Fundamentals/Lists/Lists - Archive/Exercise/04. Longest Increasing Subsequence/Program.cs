using System;
using System.Linq;
using System.Collections.Generic;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            int[] list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[] arr;
            int[] len = new int[list.Length];
            int[] prev = new int[list.Length];
            int maxLength = 0;
            int lastIndex = -1;
            for (int i = 0; i < list.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;
                for (int j = 0; j < i; j++)
                {
                    if (list[j] < list[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j; 
                    }
                }
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            arr = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                arr[i] = list[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}