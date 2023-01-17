using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {




            var n = double.Parse(Console.ReadLine());
            n = n * 100; //обръщаме в стотинки
            var two = 0;
            var one = 0;
            var fifty = 0;
            var twenty = 0;
            var ten = 0;
            var five = 0;
            var twoC = 0;
            var oneC = 0;

            while(n > 0)
            {
                // намираме има ли двулевки и колко са те
                two = (int)n / 200;
                n = (int)n % 200;
                one = (int)n / 100;
                n = (int)n % 100;
                fifty = (int)n / 50;
                n = (int)n % 50;
                twenty = (int)n / 20;
                n = (int)n % 20;
                ten = (int)n / 10;
                n = (int)n % 10;
                five = (int)n / 5;
                n = (int)n % 5;
                twoC = (int)n / 2;
                n = (int)n % 2;
                oneC = (int)n / 1;
                n = (int)n % 1;

            }
            Console.WriteLine(two+one+fifty+twenty+ten+five+twoC+oneC);












        }
    }
}
