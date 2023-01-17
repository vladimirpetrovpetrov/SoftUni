using System;

namespace Тренировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deposit = double.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            var finalSum = deposit + months * ((deposit * percent * 0.01) / 12);
            Console.WriteLine(finalSum);




        }
    }
}
