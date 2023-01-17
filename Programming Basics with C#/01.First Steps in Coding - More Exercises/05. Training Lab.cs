using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());


            var result = (Math.Floor((width - 1) / 0.70) * Math.Floor(length / 1.20)) - 3;
            Console.WriteLine(result);





        }
    }
}
