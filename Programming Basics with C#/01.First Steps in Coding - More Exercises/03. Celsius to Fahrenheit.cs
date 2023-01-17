using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            //(30°C x 1.8) + 32 = 86°F
            var farenheit = (celsius * 1.8) + 32;
            Console.WriteLine(String.Format("{0:0.00}", farenheit));
        }
    }
}
