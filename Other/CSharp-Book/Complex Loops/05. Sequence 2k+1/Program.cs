using System;

namespace Упражнения__.NET_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            // 2k + 1
            var i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i = 2 * i + 1;
            }


        }
    }
}

