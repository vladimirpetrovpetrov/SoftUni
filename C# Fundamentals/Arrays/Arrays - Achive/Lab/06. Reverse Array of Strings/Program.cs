using System;
using System.Linq;

namespace _06._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine().Split().Reverse()));
        }
    }
}
