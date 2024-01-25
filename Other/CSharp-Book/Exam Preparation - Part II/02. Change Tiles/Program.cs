using System;

namespace _02._Change_Tiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            double totalMoney = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleH = double.Parse(Console.ReadLine());
            double pricePerOneTriangle = double.Parse(Console.ReadLine());
            double workerPrice = double.Parse(Console.ReadLine());

            double floorTotalSq = widthFloor * lengthFloor;
            double triangleArea = triangleSide * triangleH / 2;
            double floorsCount = Math.Ceiling(floorTotalSq / triangleArea) + 5;
            double totalPriceForFloors = floorsCount * pricePerOneTriangle;
            double totalPrice = totalPriceForFloors + workerPrice;
            if (totalMoney >= totalPrice)
            {
                Console.WriteLine($"{totalMoney - totalPrice:0.00} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {Math.Abs(totalMoney - totalPrice):0.00} lv more.");
            }

        }
    }
}
