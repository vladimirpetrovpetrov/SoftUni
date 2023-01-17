using System;
namespace _01._Hello_SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dogFoodCount = int.Parse(Console.ReadLine());
            var catFoodCount = int.Parse(Console.ReadLine());

            double finalPrice = dogFoodCount * 2.50 + catFoodCount * 4.00;
            Console.WriteLine(finalPrice + " lv.");



        }
    }
}