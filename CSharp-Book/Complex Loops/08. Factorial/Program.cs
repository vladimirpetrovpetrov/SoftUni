using System;

namespace Числата_от_1_до_2_на_н_та_с_for_цикъл
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse(Console.ReadLine());
            //fact = 1 * 2 * 3 * 4 * 5
            var fact = 1;
            while (x >= 1)
            {
                fact *= x;
                x--;
            }
            Console.WriteLine(fact);



        }
    }
}
