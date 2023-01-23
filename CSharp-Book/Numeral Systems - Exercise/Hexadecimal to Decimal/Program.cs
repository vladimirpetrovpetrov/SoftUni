using System;

namespace Hexadecimal_to_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexDecNum = "17A6F";
            Console.WriteLine(HexToDec(hexDecNum));
            
        }

        static int HexToDec(string number)
        {
            double result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    result += (number[i] - '0') * Math.Pow(16, number.Length - i - 1);
                }else if (char.IsLetter(number[i]))
                {
                    result += (number[i] - 'A' + 10) * Math.Pow(16, number.Length - i - 1);
                }
            }
            return (int)result;



        }

    }
}
