using System;

namespace Редица_числа_2к_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 1;
            while (x <= n)
            {
                Console.WriteLine(x);
                x = 2 * x + 1;
            }
        }
    }
}
