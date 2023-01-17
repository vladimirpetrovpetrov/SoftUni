using System;

namespace Тренировка
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var maxNumber = int.MinValue;
            var minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }



            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");




        }
    }
}
