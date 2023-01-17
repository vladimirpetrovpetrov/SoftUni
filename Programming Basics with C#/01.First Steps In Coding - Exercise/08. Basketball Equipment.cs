using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yearlyPayment = int.Parse(Console.ReadLine());


            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            var shoes = yearlyPayment * 0.60;
            var clothes = shoes * 0.80;
            var ball = clothes * 0.25;
            var other = ball * 0.20;

            Console.WriteLine(yearlyPayment + clothes + shoes + ball + other);


        }
    }
}
