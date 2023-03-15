using System;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N__Core_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var baseTenNumber = BigInteger.Parse(input[1]);
            var toBase = int.Parse(input[0]);
            Console.WriteLine(DecToBase(baseTenNumber, toBase));
        }
        static string DecToBase(BigInteger num, int baseTo)
        {
            string result = string.Empty;
            while (num > 0)
            {
                result = num % baseTo + result;
                num /= baseTo;
            }
            return result;
        }
    }
}
