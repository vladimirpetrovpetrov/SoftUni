using System;

namespace _03._Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Дестинация  21 - 23 март  24 - 27 март  28 - 31 март
            //Франция     30 лв.        35 лв.        40 лв.
            //Италия      28 лв.        32 лв.        39 лв.
            //Германия    32 лв.        37 лв.        43 лв.


            var destination = Console.ReadLine();
            var dates = Console.ReadLine();
            var overnightStay = int.Parse(Console.ReadLine());
            var totalPrice = 0.0;
            switch (destination)
            {
                case "France":
                    switch (dates)
                    {
                        case "21-23":
                            totalPrice = overnightStay * 30.00;
                            break;
                        case "24-27":
                            totalPrice = overnightStay * 35.00;
                            break;
                        case "28-31":
                            totalPrice = overnightStay * 40.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Italy":
                    switch (dates)
                    {
                        case "21-23":
                            totalPrice = overnightStay * 28.00;
                            break;
                        case "24-27":
                            totalPrice = overnightStay * 32.00;
                            break;
                        case "28-31":
                            totalPrice = overnightStay * 39.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Germany":
                    switch (dates)
                    {
                        case "21-23":
                            totalPrice = overnightStay * 32.00;
                            break;
                        case "24-27":
                            totalPrice = overnightStay * 37.00;
                            break;
                        case "28-31":
                            totalPrice = overnightStay * 43.00;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");
        }
    }
}
