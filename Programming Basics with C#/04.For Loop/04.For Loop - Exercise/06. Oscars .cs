using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            var pointsAcademy = double.Parse(Console.ReadLine());
            var raters = int.Parse(Console.ReadLine());
            var sum = pointsAcademy;
            for (int i = 0; i < raters; i++)
            {
                var raterName = Console.ReadLine();
                var raterPoints = double.Parse(Console.ReadLine());

                sum = sum + ((raterName.Length * raterPoints) / 2);


                if (sum > 1250.5)
                {

                    Console.WriteLine("Congratulations, {0} got a nominee for leading role with {1}!", name, (String.Format("{0:0.0}", sum)));
                    return;
                }
            }
            var diff = String.Format("{0:0.0}", (1250.5 - sum));
            Console.WriteLine("Sorry, {0} you need {1} more!", name, diff);














        }
    }
}
