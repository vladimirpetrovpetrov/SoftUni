using System;

namespace _01._Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //•	Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце

            var easterBread = int.Parse(Console.ReadLine());
            var eggs = int.Parse(Console.ReadLine());
            var biscuits = int.Parse(Console.ReadLine());

            var expenses = easterBread * 3.20 + biscuits * 5.40 +
                eggs * 4.35;
            var eggPaint = (eggs * 12) * 0.15;
            var totalExpenses = expenses + eggPaint;
            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}
