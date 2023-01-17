using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nylonNeeded = int.Parse(Console.ReadLine());
            var paintNeeded = int.Parse(Console.ReadLine());
            var mixerNeeded = int.Parse(Console.ReadLine());
            var hoursNeeded = int.Parse(Console.ReadLine());

            //•	Предпазен найлон -1.50 лв.за кв. метър
            //•	Боя - 14.50 лв.за литър
            //•	Разредител за боя - 5.00 лв.за литър

            var priceMats = (nylonNeeded + 2) * 1.50 + (paintNeeded * 14.50) * 1.10 + mixerNeeded * 5.00 + 0.40;

            var priceWorkers = hoursNeeded * (priceMats * 0.30);
            Console.WriteLine(priceMats + priceWorkers);


        }
    }
}