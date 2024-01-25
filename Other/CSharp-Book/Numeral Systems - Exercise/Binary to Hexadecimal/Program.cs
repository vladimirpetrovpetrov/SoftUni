using System;

namespace Binary_to_HexDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryNum = 1111010110011110;
            Console.WriteLine(BinaryToHex(binaryNum));
            Console.WriteLine(BinaryToHex(11111));
        }

        static string BinaryToHex(long binaryNum)
        {
            return DecToHex(BinaryToDec(binaryNum));
        }
        static string DecToHex(int decNum)
        {
            string hexDecNums = "0123456789ABCDEF";
            string result = string.Empty;

            while (decNum > 0)
            {
                int index = decNum % 16;
                result = hexDecNums[index] + result;
                decNum /= 16;
            }
            return result;
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

