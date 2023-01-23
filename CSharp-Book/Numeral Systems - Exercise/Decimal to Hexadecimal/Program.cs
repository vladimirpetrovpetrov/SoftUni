using System;

namespace Decimal_to_Hexadecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNum = 1234329;
            Console.WriteLine(DecToHexDec(decNum));
        }
        static string DecToHexDec(int number)
        {
            string result = string.Empty;
            string hexDecNumbers = "0123456789ABCDEF";

            while (number > 0)
            {
                int digitValue = number % 16;
                result = hexDecNumbers[digitValue] + result;
                number /= 16;
            }
            return result;
        }
    }
}
