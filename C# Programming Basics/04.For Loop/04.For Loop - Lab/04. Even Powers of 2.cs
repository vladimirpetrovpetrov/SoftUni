using System;

namespace Тренировка
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {

                if (i % 2 == 0)
                {
                    var result = Math.Pow(2, i);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
