using System;

namespace _07._Football_League
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int stadiumCrowd = int.Parse(Console.ReadLine());
            double sectorA = 0.0;
            double sectorB = 0.0;
            double sectorV = 0.0;
            double sectorG = 0.0;

            for (int i = 0; i < stadiumCrowd; i++)
            {
                string sector = Console.ReadLine().ToUpper();
                if (sector == "A")
                {
                    sectorA++;
                }
                else if (sector == "B")
                {
                    sectorB++;
                }
                else if (sector == "V")
                {
                    sectorV++;
                }
                else if (sector == "G")
                {
                    sectorG++;
                }
            }
            double filledUpStadiumInP = (double)stadiumCrowd / stadiumCapacity * 100;
            Console.WriteLine($"{sectorA / stadiumCrowd * 100:0.00}%");
            Console.WriteLine($"{sectorB / stadiumCrowd * 100:0.00}%");
            Console.WriteLine($"{sectorV / stadiumCrowd * 100:0.00}%");
            Console.WriteLine($"{sectorG / stadiumCrowd * 100:0.00}%");
            Console.WriteLine($"{filledUpStadiumInP:0.00}%");
        }
    }
}
