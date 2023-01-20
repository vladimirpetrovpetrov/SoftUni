using System;

namespace Упражнения__.NET_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //2^0 2^2 2^4 2^6 2^8
            var sum = 1;
            for (int i = 0; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(sum);
                    sum = sum * 4;
                }
            }
        }
    }
}
