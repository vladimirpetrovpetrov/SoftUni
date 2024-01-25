using System;

namespace _03._Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eggsSize = Console.ReadLine();
            var eggsColor = Console.ReadLine();
            var eggsCount = int.Parse(Console.ReadLine());
            var eggPrice = 0.0;

            switch (eggsSize)
            {
                case "Large":
                    switch (eggsColor)
                    {
                        case "Red":
                            eggPrice = 16.00;
                            break;
                        case "Green":
                            eggPrice = 12.00;
                            break;
                        case "Yellow":
                            eggPrice = 9.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Medium":
                    switch (eggsColor)
                    {
                        case "Red":
                            eggPrice = 13.00;
                            break;
                        case "Green":
                            eggPrice = 9.00;
                            break;
                        case "Yellow":
                            eggPrice = 7.00;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Small":
                    switch (eggsColor)
                    {
                        case "Red":
                            eggPrice = 9.00;
                            break;
                        case "Green":
                            eggPrice = 8.00;
                            break;
                        case "Yellow":
                            eggPrice = 5.00;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            eggPrice *= eggsCount;
            eggPrice *= 0.65;
            Console.WriteLine($"{eggPrice:f2} leva.");
        }
    }
}
