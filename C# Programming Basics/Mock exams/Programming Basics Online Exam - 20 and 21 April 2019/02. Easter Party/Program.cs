using System;

namespace _02._Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Между 10(вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
            //•	Между 15 и 20(вкл.) човека-> 20 % отстъпка от куверта за един човек
            //•	Над 20 човека-> 25 % отстъпка от куверта за един човек


            var guestCount = int.Parse(Console.ReadLine());
            var pricePerGuest = int.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            double finalPricePerGuest = 0.0;
            if(guestCount >= 10 && guestCount <= 15)
            {
                finalPricePerGuest = pricePerGuest * 0.85;
            }else if (guestCount > 15 && guestCount <= 20)
            {
                finalPricePerGuest = pricePerGuest * 0.80;
            }else if (guestCount > 20)
            {
                finalPricePerGuest = pricePerGuest * 0.75;
            }
            else { finalPricePerGuest = pricePerGuest; }

            var totalCost = finalPricePerGuest * guestCount + budget * 0.10;
            if(totalCost <= budget)
            {
                Console.WriteLine($"It is party time! {budget-totalCost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalCost-budget:f2} leva needed.");
            }
        }
    }
}
