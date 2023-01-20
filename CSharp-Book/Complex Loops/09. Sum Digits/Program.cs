using System;

namespace Числата_от_1_до_2_на_н_та_с_for_цикъл
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var sum = 0;
            while (x > 0)
            {
                sum += x % 10;

                x = x / 10;

            }
            Console.WriteLine(sum);
        }
    }
}