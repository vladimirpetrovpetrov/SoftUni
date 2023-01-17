using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var statistCount = int.Parse(Console.ReadLine());
            var clothesPerOneStatist = double.Parse(Console.ReadLine());


            //•	Декорът за филма е на стойност 10 % от бюджета.
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.

            var decor = budget * 0.10;
            if (statistCount > 150)
            {
                clothesPerOneStatist -= clothesPerOneStatist * 0.10;
            }
            var totalCost = decor + statistCount * clothesPerOneStatist;
            if (totalCost > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {String.Format("{0:0.00}", totalCost - budget)} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {String.Format("{0:0.00}", budget - totalCost)} leva left.");
            }



        }
    }
}
