using System;

namespace Тренировка
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //var n = int.Parse(Console.ReadLine());
            var word = Console.ReadLine();

            foreach (var letter in word)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
