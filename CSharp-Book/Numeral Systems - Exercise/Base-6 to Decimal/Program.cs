using System;
using System.Numerics;

namespace Base_6_to_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseSixNum = 12345;
            Console.WriteLine(BaseSixToDec(baseSixNum));
        }
        static BigInteger BaseSixToDec(int num)
        {
            double result = 0;
            string sNum = num.ToString();
            int length = sNum.Length;
            for (int i = 0; i < length; i++)
            {
                result += (sNum[i]-'0') * Math.Pow(6, length - 1 - i);
            }
            return (BigInteger)result;
        }
    }
}
