using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmLength = int.Parse(Console.ReadLine());
            var cmWidth = int.Parse(Console.ReadLine());
            var cmHeigth = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            var volTankCm = cmLength * cmWidth * cmHeigth; //cm3
            var volTankDcm = volTankCm * 0.001;

            var result = volTankDcm - (volTankDcm * percent * 0.01);
            Console.WriteLine(result);

        }
    }
}
