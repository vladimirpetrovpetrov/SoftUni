using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var graphicCardCount = int.Parse(Console.ReadLine());
            var processorCount = int.Parse(Console.ReadLine());
            var ramCount = int.Parse(Console.ReadLine());

            //•	Видеокарта – 250 лв./ бр.
            //•	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //•	Рам памет – 10 % от цената на закупените видеокарти/ бр.

            //Ако броя на видеокартите
            //е по-голям от този на процесорите получава
            //15% отстъпка от крайната сметка


            const double gCost = 250;

            var gTotalCost = graphicCardCount * gCost;
            var pTotalCost = (gTotalCost * 0.35) * processorCount;
            var rTotalCost = (gTotalCost * 0.10) * ramCount;

            var totalCost = gTotalCost + pTotalCost + rTotalCost;


            if (graphicCardCount > processorCount)
            {
                totalCost *= 0.85;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"You have {String.Format("{0:0.00}", (budget - totalCost))} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {String.Format("{0:0.00}", (totalCost - budget))} leva more!");

            }









        }
    }
}
