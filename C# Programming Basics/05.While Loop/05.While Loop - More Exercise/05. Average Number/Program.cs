using System;
using System.Linq;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            Console.WriteLine(String.Format("{0:0.00}",numbers.Average()));
        }
    }
}
