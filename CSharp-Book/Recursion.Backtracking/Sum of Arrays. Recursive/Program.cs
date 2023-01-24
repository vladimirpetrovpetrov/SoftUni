using System;
using System.Linq;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sum = Sum(numbers, 0);
            Console.WriteLine(sum);
        }
        static int Sum(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            var currentSum = arr[index] + Sum(arr, index + 1);
            return currentSum;
        }

    }
}
