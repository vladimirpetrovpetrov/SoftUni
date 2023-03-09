using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Take___Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine();
            var numbers = input.Where(x => Char.IsDigit(x)).ToList();
            var numbersStr = numbers.Select(x => x.ToString()).ToList();
            var numbersInt = numbersStr.Select(int.Parse).ToList();
            var nonNumbers = input.Where(x => !Char.IsDigit(x)).ToList();
            

            var take = new List<int>();
            var skip = new List<int>();

            for (int i = 0; i < numbersInt.Count; i++)
            {
                if(i%2==0)
                {
                    take.Add(numbersInt[i]);
                }
                else
                {
                    skip.Add(numbersInt[i]);
                }
            }
            //T e x s t i n g _ c T h e _ R o p p e
            string result = string.Empty;
            int skipNum = 0;
            for (int i = 0; i < skip.Count; i++)
            {
                int takeNum = take[i];
                var list = nonNumbers.Skip(skipNum).Take(takeNum).ToList();
                for (int j = 0; j < list.Count; j++)
                {
                    result += list[j];
                }
                skipNum += skip[i]+=takeNum;
            }
            Console.WriteLine(result);
        }
    }
}
