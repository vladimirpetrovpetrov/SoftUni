using System;

namespace Пирамида_от_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (num > n)
                    {
                        return;
                    }
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
        }
    }
}
