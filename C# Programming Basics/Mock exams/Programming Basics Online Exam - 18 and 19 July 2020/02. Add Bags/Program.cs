using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var priceOver20kg = double.Parse(Console.ReadLine());
            var luggageKG = double.Parse(Console.ReadLine());
            var daysLeft = int.Parse(Console.ReadLine());
            var luggageCount = int.Parse(Console.ReadLine());
            double priceForTheLuggage;

            if(luggageKG < 10)
            { 
                priceForTheLuggage = priceOver20kg *0.20;
            }else if(luggageKG>=10 && luggageKG <= 20)
            {

                priceForTheLuggage = priceOver20kg * 0.50;
            }
            else
            {
                priceForTheLuggage = priceOver20kg;
            }

            if(daysLeft > 30)
            {
                priceForTheLuggage *= 1.10;
            }else if(daysLeft <=30 && daysLeft >= 7)
            {
                priceForTheLuggage *= 1.15;
            }
            else
            {
                priceForTheLuggage *= 1.40;
            }
            Console.WriteLine($"The total price of bags is: {priceForTheLuggage*luggageCount:f2} lv.");
        }
    }
}
