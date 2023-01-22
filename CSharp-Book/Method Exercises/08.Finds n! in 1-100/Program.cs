using System;
using System.Numerics;

namespace Finds_n__in_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var n = int.Parse(Console.ReadLine());
            var n = 27;
            Factoriel(n);

        }

        static void Factoriel(int end = 100)
        {
            BigInteger result = 1;
            for (int i = 1; i <= end; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result *= j;
                }
                Console.WriteLine($"Factoriel({i}) = {result}");
                result = 1;
            }
        }





    }
}
