using System;
using System.Linq;

namespace Base_6_float_number_to_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 123.45;
            Console.WriteLine($"{BaseSixToDec(num)}");
        }
        static double BaseSixToDec(double num)
        {
            double firstPart = 0;
            int[] numParts = num.ToString().Split('.').Select(int.Parse).ToArray();
            string sFirstPart = numParts[0].ToString();
            int length1 = sFirstPart.Length;

            for (int i = 0; i < length1; i++)
            {
                firstPart += (sFirstPart[i]-'0') * (Math.Pow(6, length1 - i - 1));
            }
            double secondPart = 0;
            string sSecondPart = numParts[1].ToString();
            int length2 = sSecondPart.Length;

            for (int i = 0; i < length2; i++)
            {
                secondPart += (sSecondPart[i] - '0') * (Math.Pow(6, (i+1)*-1));
            }
            return firstPart + secondPart;
            
        }
    }
}
