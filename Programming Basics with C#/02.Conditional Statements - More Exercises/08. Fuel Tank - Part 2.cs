using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fuelType = Console.ReadLine();
            var litersFuel = double.Parse(Console.ReadLine());
            var card = Console.ReadLine();
            var gasPrice = 0.0;
            var gasolinePrice = 0.0;
            var dieselPrice = 0.0;
            switch (card)
            {
                case "Yes":
                    switch (fuelType)
                    {
                        case "Gas":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                gasPrice = ((0.93 - 0.08) * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                gasPrice = ((0.93 - 0.08) * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            else
                            {
                                gasPrice = (0.93 - 0.08) * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            break;
                        case "Gasoline":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                gasolinePrice = ((2.22 - 0.18) * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                gasolinePrice = ((2.22 - 0.18) * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            else
                            {
                                gasolinePrice = (2.22 - 0.18) * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            break;
                        case "Diesel":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                dieselPrice = ((2.33 - 0.12) * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                dieselPrice = ((2.33 - 0.12) * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            else
                            {
                                dieselPrice = (2.33 - 0.12) * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "No":
                    switch (fuelType)
                    {
                        case "Gas":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                gasPrice = (0.93 * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                gasPrice = (0.93 * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            else
                            {
                                gasPrice = 0.93 * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", gasPrice) + " lv."));
                            }
                            break;
                        case "Gasoline":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                gasolinePrice = (2.22 * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                gasolinePrice = (2.22 * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            else
                            {
                                gasolinePrice = 2.22 * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", gasolinePrice) + " lv."));
                            }
                            break;
                        case "Diesel":
                            if (litersFuel >= 20 && litersFuel <= 25)
                            {
                                dieselPrice = (2.33 * litersFuel) * 0.92;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            else if (litersFuel > 25)
                            {
                                dieselPrice = (2.33 * litersFuel) * 0.90;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            else
                            {
                                dieselPrice = 2.33 * litersFuel;
                                Console.WriteLine((String.Format("{0:0.00}", dieselPrice) + " lv."));
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
