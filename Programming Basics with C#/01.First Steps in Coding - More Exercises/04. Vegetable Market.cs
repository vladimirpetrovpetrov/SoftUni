using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var priceKGveg = double.Parse(Console.ReadLine());
            var priceKGfr = double.Parse(Console.ReadLine());
            var kgVeg = double.Parse(Console.ReadLine());
            var kgFr = double.Parse(Console.ReadLine());
            const double lvEuro = 1.94;

            var price = priceKGfr * kgFr + priceKGveg * kgVeg;
            var finalPrice = price / lvEuro;




            Console.WriteLine(String.Format("{0:0.00}", finalPrice));
        }
    }
}
