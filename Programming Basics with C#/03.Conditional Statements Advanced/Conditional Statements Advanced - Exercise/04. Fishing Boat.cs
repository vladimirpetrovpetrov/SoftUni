using System;

namespace Лодка_за_Риболов
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         •	Цената за наем на кораба през пролетта е  3000 лв.
         •	Цената за наем на кораба през лятото и есента е  4200 лв.
         •	Цената за наем на кораба през зимата е  2600 лв.

         •	Ако групата е до 6 човека включително  –  отстъпка от 10%.
         •	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15%.
         •	Ако групата е от 12 нагоре  –  отстъпка от 25%. 

            Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен 
            ако не е есен - тогава нямат допълнителна отстъпка, която се начислява 
            след като се приспадне отстъпката по горните критерии.

              */

            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var fishermen = int.Parse(Console.ReadLine());
            var price = 0.00;


            switch (season)
            {
                case "Spring":
                    if (fishermen <= 6)
                    {
                        price = 3000 - (3000 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 3000 - (3000 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 3000 - (3000 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }
                    break;
                case "Summer":



                    if (fishermen <= 6)
                    {
                        price = 4200 - (4200 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 4200 - (4200 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 4200 - (4200 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }
                    break;
                case "Autumn":


                    if (fishermen <= 6)
                    {
                        price = 4200 - (4200 * 0.10);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }

                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 4200 - (4200 * 0.15);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 4200 - (4200 * 0.25);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }
                    }

                    break;
                case "Winter":
                    if (fishermen <= 6)
                    {
                        price = 2600 - (2600 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 2600 - (2600 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 2600 - (2600 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    break;
            }



        }
    }
}
