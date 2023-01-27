using System;
using System.Linq;

namespace _2._Reverse_an_Array_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                ints[i] = num;

            }
            Console.Write(String.Join(" ",ints.Reverse()));
        }
    }
}
