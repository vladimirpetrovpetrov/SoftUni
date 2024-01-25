using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var count = double.Parse(Console.ReadLine());
            var cena = 0.0;
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            cena = count * 2.50;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "apple":
                            cena = count * 1.20;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "orange":
                            cena = count * 0.85;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "grapefruit":
                            cena = count * 1.45;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "kiwi":
                            cena = count * 2.70;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "pineapple":
                            cena = count * 5.50;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "grapes":
                            cena = count * 3.85;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            cena = count * 2.70;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "apple":
                            cena = count * 1.25;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "orange":
                            cena = count * 0.90;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "grapefruit":
                            cena = count * 1.60;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "kiwi":
                            cena = count * 3.00;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "pineapple":
                            cena = count * 5.60;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        case "grapes":
                            cena = count * 4.20;
                            Console.WriteLine((String.Format("{0:0.00}", cena)));
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }





        }
    }
}
