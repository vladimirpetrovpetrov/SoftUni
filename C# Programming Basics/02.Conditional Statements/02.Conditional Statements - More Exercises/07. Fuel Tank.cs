using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fuelType = Console.ReadLine();
            var litersInTank = int.Parse(Console.ReadLine());


            switch (fuelType)
            {
                case "Diesel":
                case "Gasoline":
                case "Gas":
                    if (litersInTank < 25)
                    {
                        Console.WriteLine("Fill your tank with {0}!", fuelType.ToLower());
                    }
                    else
                    {
                        Console.WriteLine("You have enough {0}.", fuelType.ToLower());
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }


        }
    }
}
