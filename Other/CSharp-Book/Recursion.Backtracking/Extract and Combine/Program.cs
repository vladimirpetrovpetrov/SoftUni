using System;
using System.Numerics;

namespace Extract_and_Combine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Factoriel(n));
        }
        static long Factoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            long result = n * Factoriel(n - 1);
            return result;
        }
    }
}
