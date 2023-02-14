using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double pigWeigth = double.Parse(Console.ReadLine());

            double foodGr = quantityFood * 1000;
            double hayGr = quantityHay * 1000;
            double coverGr = quantityCover * 1000;
            double pigGr = pigWeigth * 1000;


            for (int i = 1; i <= 30; i++)
            {
                foodGr -= 300;
                if (i % 2 == 0)
                {
                    hayGr -= (foodGr * 0.05);
                }
                if(i%3==0)
                {
                    coverGr -= (pigGr / 3);
                }
                if(foodGr<=0 || hayGr<=0 || coverGr <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodGr/1000:f2}, Hay: {hayGr / 1000:f2}, Cover: {coverGr / 1000:f2}.");
        }
    }
}
