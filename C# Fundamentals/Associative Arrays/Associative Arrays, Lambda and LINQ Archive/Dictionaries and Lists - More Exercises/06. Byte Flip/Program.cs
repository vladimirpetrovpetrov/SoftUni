using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Byte_Flip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length == 2).ToList();
            var intList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                var temp = string.Empty;
                for (int j = input[i].Length - 1; j >= 0; j--)
                {
                    temp += input[i][j];
                }
                input[i] = temp;
            }
            input.Reverse();
            for (int i = 0; i < input.Count; i++)
            {
                intList.Add(HexToDec(input[i]));
            }
            string result = string.Empty;
            foreach (var item in intList)
            {
                result += (char)item;
            }
            Console.WriteLine(result);
        }
        static int HexToDec(string number)
        {
            double result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsDigit(number[i]))
                {
                    result += (number[i] - '0') * Math.Pow(16, number.Length - i - 1);
                }
                else if (char.IsLetter(number[i]))
                {
                    result += (number[i] - 'A' + 10) * Math.Pow(16, number.Length - i - 1);
                }
            }
            return (int)result;
        }
    }
}
