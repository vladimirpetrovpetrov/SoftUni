using System;

namespace Generating_0_1_Vectors__generating_combinations__Recursion
{
    internal class Program
    {
        static void Generate(int index, int[] arr)
        {
            if (index == arr.Length)
            {
                foreach (var item in arr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Generate(index + 1, arr);
                }
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            Generate(0, arr);
        }
    }
}
/*
using System;

namespace TEST
{
    internal class Program
    {

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Bits(n, "");
        }

        static void Bits(int n, string bits)
        {
            if (n == 0)
            {
                Console.WriteLine(bits);
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                Bits(n - 1, bits + i);
            }
        }
    }
}
*/