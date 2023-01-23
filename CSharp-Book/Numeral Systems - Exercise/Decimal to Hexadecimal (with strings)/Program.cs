using System;

namespace Decimal_to_Hexadecimal__with_strings_
{
    internal class Program
    {
        //10 --> dsa , 11 --> ?dw , 12 --> deee , 13 --> cat , 14 --> dog, 15--> aligator
        static void Main(string[] args)
        {
            int decNum = 392432543;
            Console.WriteLine(DecToHex(decNum));
        }
        static string DecToHex(int number)
        {
            string result = string.Empty;
            string[] hexDecNumbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "dsa", "?dw", "deee", "cat", "dog", "aligator" };

            while (number > 0)
            {
                int index = number % 16;
                result = hexDecNumbers[index] + result;
                number /= 16;
            }
            return result;
        }
    }
}
