using System;

namespace Decimal_to_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decNum = 123;
            Console.WriteLine(DecToBinary(decNum));

        }
        static string DecToBinary(int num) // 16 --> 16%2 = 0 --> 16/2 = 8 8%2 = 0 8/2 = 4 4 % 2 = 0 4/2 = 2 2 % 2 = 0 2\2 = 1 1 % 2 = 1 
        {
            string result = "";
            while(num>0) 
            {
                result = num % 2 + result;///-->  result = result + (num % 2)
                num /= 2;
            }
            return result;
        }
    }
}
