using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pagesCount = int.Parse(Console.ReadLine()); //212 pages
            var pagePerHour = int.Parse(Console.ReadLine()); //20 pages per hour
            var dayPerBook = int.Parse(Console.ReadLine()); //2

            double result = (pagesCount / pagePerHour) / dayPerBook;
            Console.WriteLine(result);

        }
    }
}