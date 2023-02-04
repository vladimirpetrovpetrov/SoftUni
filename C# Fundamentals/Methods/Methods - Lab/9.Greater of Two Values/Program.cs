using System;
using System.Collections.Generic;

namespace _9.Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            
            if (type == "int")
            {
                int firstI = int.Parse(first);
                int secondI = int.Parse(second);
                Console.WriteLine(   GetMax(firstI, secondI));
            }
            else if (type == "char")
            {
                char firstI = char.Parse(first);
                char secondI = char.Parse(second);
                Console.WriteLine(GetMax(firstI, secondI));
            }
            else 
            {
                string firstI = first;
                string secondI = second;
                Console.WriteLine(GetMax(firstI, secondI));
            }

            
        }
        static int GetMax(int x , int y)
        {
            return x>=y ? x : y;
        }
        static char GetMax(char x, char y)
        {
            return x >= y ? x : y;
        }
        static string GetMax(string x, string y)
        {
            return String.Compare(x, y) <= 0 ? y : x;
        }
    }
}
