using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obem = int.Parse(Console.ReadLine());
            var debitP1 = int.Parse(Console.ReadLine());
            var debitP2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var p1 = hours * debitP1;
            var p2 = hours * debitP2;
            var obshto = p1 + p2;
            var obshtoPercent = (p1 + p2) / (double)obem * 100;
            var p1Percent = ((double)p1 / (double)obshto) * 100;
            var p2Percent = ((double)p2 / (double)obshto) * 100;

            if (p1 + p2 > obem)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, String.Format("{0:0.00}", ((p1 + p2) - obem)));
            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", String.Format("{0:0.00}", obshtoPercent), String.Format("{0:0.00}", p1Percent), String.Format("{0:0.00}", p2Percent));
            }




        }
    }
}
