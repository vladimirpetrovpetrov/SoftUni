using System;

namespace _01._Distance
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            int startingkmInH = int.Parse(Console.ReadLine());
            int minsWithStartingSpeed = int.Parse(Console.ReadLine());
            int minsWithSecondSpeed = int.Parse(Console.ReadLine());
            int minsWithThirdSpeed = int.Parse(Console.ReadLine());

            double firstDistance = startingkmInH * ((double)minsWithStartingSpeed / 60);
            double secondDistance = startingkmInH * 1.10 * ((double)minsWithSecondSpeed / 60);
            double thirdDistance = startingkmInH * 1.10 * 0.95
                * ((double)minsWithThirdSpeed / 60);
            double totalDistance = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine($"{totalDistance:0.00}");
        }
    }
}
