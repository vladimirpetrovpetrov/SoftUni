using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var skumriqCenaKg = double.Parse(Console.ReadLine());
            var cacaCenaKg = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = int.Parse(Console.ReadLine());

            //              •	Паламуд – 60 % по - скъп от скумрията
            //              •	Сафрид – 80 % по - скъп от цацата
            //              •	Миди – 7.50 лв.за килограм

            var paladmudCenaKg = skumriqCenaKg * 1.60;
            var safridCenaKg = cacaCenaKg * 1.80;
            var cenaMidiKg = 7.50;

            var finalPrice = palamudKg * paladmudCenaKg + safridCenaKg * safridKg +
                midiKg * cenaMidiKg;





            Console.WriteLine(String.Format("{0:0.00}", finalPrice));
        }
    }
}