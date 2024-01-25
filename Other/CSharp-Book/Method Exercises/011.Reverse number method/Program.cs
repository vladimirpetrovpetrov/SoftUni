using System;
using System.Linq;

namespace Reverse_number_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumberDigits(652));
            Console.WriteLine(ReverseNumberDigits2(7321));
        }

        static double ReverseNumberDigits(int number)
        {
            var num = "";
            while (number > 0)
            {
                num += number % 10;
                number /= 10;
            }
            var result = double.Parse(num);
            return result;
        }

        static double ReverseNumberDigits2(int number)
        {
            var sNum = number.ToString();
            var sResult = "";
            for (int i = 0; i < sNum.Length; i++)
            {
                sResult += sNum[sNum.Length - i - 1];
            }
            return double.Parse(sResult);
        }



    }
}
