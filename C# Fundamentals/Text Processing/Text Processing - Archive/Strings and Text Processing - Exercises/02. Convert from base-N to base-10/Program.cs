using System;
using System.Numerics;

namespace _02._Convert_from_base_N_to_base_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var number = BigInteger.Parse(input[1]);
            var baseSystem = int.Parse(input[0]);
            Console.WriteLine(BaseToDec(number,baseSystem));
        }
        static BigInteger BaseToDec(BigInteger num,int baseSy)
        {
            BigInteger result = 0;
            string sNum = num.ToString();
            int length = sNum.Length;
            for (int i = 0; i < length; i++)
            {
                result += (sNum[i] - '0') * BigInteger.Pow(baseSy, length - 1 - i);
            }
            return (BigInteger)result;
        }
    }
}
