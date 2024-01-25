using System;

namespace “ренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chickenCount = int.Parse(Console.ReadLine());
            var fishCount = int.Parse(Console.ReadLine());
            var veggieCount = int.Parse(Console.ReadLine());


            //Х	ѕилешко меню Ц  10.35 лв.
            //Х	ћеню с риба Ц 12.40 лв.
            //Х	¬егетарианско меню  Ц 8.15 лв.
            var price = chickenCount * 10.35 + fishCount * 12.40 + veggieCount * 8.15;
            var desert = 0.20 * price;
            var finalPrice = price + desert + 2.50;
            Console.WriteLine(finalPrice);

        }
    }
}
