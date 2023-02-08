using System;
using System.Numerics;

namespace _14._Factorial_Trailing_Zeroes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            TrailingZeros(n);
        }
        static BigInteger Factoriel(BigInteger n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factoriel(n - 1);
        }
        static void TrailingZeros(BigInteger n)
        {
            var result = Factoriel(n);
            BigInteger lastDigit = 0;
            int count = 0;
            while (n > 0)
            {
                lastDigit = result % 10;
                if (lastDigit != 0)
                {
                    break;
                }
                count++;
                result = result / 10;
            }
            Console.WriteLine(count);
        }
    }
}
