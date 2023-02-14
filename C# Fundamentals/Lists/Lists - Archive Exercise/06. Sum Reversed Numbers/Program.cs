using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Sum_Reversed_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            for (int i = 0; i < x.Count; i++)
            {
                x[i] = ReverseDigits(x[i]);
            }
            Console.WriteLine(x.Sum());
        }
        static int ReverseDigits(int num)
        {
            string sNum = num.ToString();
            var s = sNum.Reverse().ToList();
            string result = string.Empty;
            foreach (var item in s)
            {
                string a = item.ToString();
                result += a;
            }
            return int.Parse(result);

        }
    }
}
