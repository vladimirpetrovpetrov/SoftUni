using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var joineryCount = int.Parse(Console.ReadLine()); 
            var joineryType = Console.ReadLine(); 
            var delivery = Console.ReadLine();
            double pricePerOneJoinery = 0;

            if (joineryCount < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            switch (joineryType)
            {
                case "90X130":
                    if(joineryCount > 60)
                    {
                        pricePerOneJoinery = 110.0 * 0.92;
                    }else if (joineryCount > 30 && joineryCount <= 60)
                    {
                        pricePerOneJoinery = 110.0 * 0.95; 
                    }
                    else
                    {
                        pricePerOneJoinery = 110.0;
                    }
                    break;
                case "100X150":
                    if (joineryCount > 80)
                    {
                        pricePerOneJoinery = 140.0 * 0.90;
                    }
                    else if (joineryCount > 40 && joineryCount <= 80)
                    {
                        pricePerOneJoinery = 140.0 * 0.94;
                    }
                    else
                    {
                        pricePerOneJoinery = 140.0;
                    }
                    break;
                case "130X180":
                    if (joineryCount > 50)
                    {
                        pricePerOneJoinery = 190.0 * 0.88;
                    }
                    else if (joineryCount > 20 && joineryCount <= 50)
                    {
                        pricePerOneJoinery = 190.0 * 0.93;
                    }
                    else
                    {
                        pricePerOneJoinery = 190.0;
                    }
                    break;
                case "200X300":
                    if (joineryCount > 50)
                    {
                        pricePerOneJoinery = 250.0 * 0.86;
                    }
                    else if (joineryCount > 25 && joineryCount <= 50)
                    {
                        pricePerOneJoinery = 250.0 * 0.91;
                    }
                    else
                    {
                        pricePerOneJoinery = 250.0;
                    }
                    break;
                default:
                    break;
            }

            var totalPrice = pricePerOneJoinery * joineryCount; //4180
            if(delivery == "With delivery")
            {
                totalPrice += 60; 
            }
            if (joineryCount > 99)
            {
                totalPrice *= 0.96;
            }

            Console.WriteLine($"{totalPrice:f2} BGN");
        }
    }
}
