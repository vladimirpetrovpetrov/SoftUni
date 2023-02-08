using System;

namespace _04._Numbers_in_Reversed_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sNum = Console.ReadLine();
            Console.WriteLine(Reverse(sNum));
        }
        static string Reverse(string num)
        {
            string reversedNum = string.Empty;
            for (int i = 0; i < num.Length; i++)
            {
                reversedNum += num[num.Length - 1 - i];
            }
            return reversedNum;
        }
    }
}
