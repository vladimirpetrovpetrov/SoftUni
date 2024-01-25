using System;

namespace Decimal_to_Base6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNum = 899751;
            Console.WriteLine(DecToBaseSix(decNum));
        }
        static string DecToBaseSix(int num)
        {
            string result = string.Empty;
            while(num > 0)
            {
                result = num % 6 + result;
                num /= 6;
            }
            return result;
        }
    }
}
