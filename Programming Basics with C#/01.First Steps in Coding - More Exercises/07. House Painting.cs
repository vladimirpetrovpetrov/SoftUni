using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());


            //червена боя = 1Л -> 4.3 кв.м.
            //зелена боя=   1Л -> 3.4 кв.м.

            //предна и задна стена
            var zadnaStena = x * x;

            var prednaStena = x * x - 1.20 * 2.00;

            var stranichnaStena = x * y - (1.5 * 1.5);

            var trigylni = (x * 0.5) * h;

            var pokriv = x * y;

            var zelenaBoq = zadnaStena + prednaStena + 2 * stranichnaStena;
            var chervenaBoq = 2 * trigylni + 2 * pokriv;
            Console.WriteLine(String.Format("{0:0.00}", zelenaBoq / 3.4));
            Console.WriteLine(String.Format("{0:0.00}", chervenaBoq / 4.3));



        }
    }
}