using System;
using System.Runtime.CompilerServices;

namespace static_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.GiveMePI());
            
        }
    }
    public static class Math
    {
        private const double PI = 3.14;

        public static double GiveMePI()
        {
            return PI;
        }
    }
}
