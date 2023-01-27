using System;
using System.Linq;

namespace _4._Triple_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    bool contains = arr.Contains(arr[i] + arr[j]);
                    if (contains)
                    {
                        count++;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[i] + arr[j]}");
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
