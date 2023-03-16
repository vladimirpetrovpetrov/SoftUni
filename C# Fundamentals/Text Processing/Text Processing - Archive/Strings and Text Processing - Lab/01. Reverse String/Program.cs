using System;
using System.Linq;

namespace _01._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            input = new string(input.Reverse().ToArray());
            Console.WriteLine(input);

        }
    }
}
