using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary_to_HexDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryNum = 111111;
            //Console.WriteLine(BinaryToDec(binaryNum));
            var numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} : {BinaryToDec(numbers[i])}");
            }


        }
        static int BinaryToDec(long binaryNum)
        {
            double result = 0;
            string sNum = binaryNum.ToString();
            int length = sNum.Length;
            for (int i = 0; i < length; i++)
            {
                result += (sNum[i] - '0') * Math.Pow(2, length - i - 1);
            }
            return (int)result;
        }
    }

}

