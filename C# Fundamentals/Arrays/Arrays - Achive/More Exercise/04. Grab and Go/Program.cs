using System;
using System.Linq;
using System.Numerics;
using System.Transactions;

namespace _04._Grab_and_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var inputArray = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            BigInteger num = int.Parse(Console.ReadLine());

           int lastIndex = Array.LastIndexOf(inputArray, num);
           if(lastIndex >= 0)
            {
                BigInteger sum = 0;
                for (int i = 0; i < lastIndex; i++)
                {
                    sum += inputArray[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }







        }
    }
}
