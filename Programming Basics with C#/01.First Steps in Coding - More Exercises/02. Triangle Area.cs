using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());

            var h = double.Parse(Console.ReadLine());

            var result = a * h / 2;
            Console.WriteLine(String.Format("{0:0.00}", result));
        }
    }
}
