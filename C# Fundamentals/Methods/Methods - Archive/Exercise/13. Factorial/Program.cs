using System;
using System.Numerics;

namespace _13._Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(n));
        }
        static BigInteger Factoriel(BigInteger n)
        {
            if (n == 1)
            { 
                return 1; 
            }

            return n * Factoriel(n-1);
        }
    }
}
