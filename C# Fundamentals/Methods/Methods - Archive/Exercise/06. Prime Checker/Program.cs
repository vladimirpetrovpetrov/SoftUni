using System;

namespace _06_PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num));
        }

        static bool IsPrime(long num)
        {
            num = Math.Abs(num);
            bool isItPrime = true;

            if (num == 2)
            {
                return true;
            }
            else if (num == 1 || num == 0)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isItPrime = false;
                    break;
                }
            }
            return isItPrime;
        }
    }
}