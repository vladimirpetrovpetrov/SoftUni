using System;
using System.Linq;

namespace _8._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < x.Length-1; i++)
            {
                for (int j = 0; j <x.Length-1-i ; j++)
                {

                    x[j] = x[j] + x[j+1];

                }
            }
            Console.WriteLine(x[0]);
        }
    }
}
