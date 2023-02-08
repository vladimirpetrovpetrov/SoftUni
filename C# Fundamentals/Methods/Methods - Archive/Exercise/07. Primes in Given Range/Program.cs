using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<int> primeNumbers = GetPrimeNumbers(a, b);
            List<int> result = primeNumbers.Where(x=> x != 0 && x != 1).ToList();
            
            Console.WriteLine(String.Join(", ",result));
        }

        static List<int> GetPrimeNumbers(int start, int end)
        {
            List<int> primeNumbers = new List<int>();
            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(num);
                }
            }
            return primeNumbers;
        }
    }
}
