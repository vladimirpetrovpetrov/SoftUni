using System;

namespace _05._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eggsCount = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int blue = 0;
            int green = 0;
            var max = int.MinValue;
            var maxColor = " ";
            for (int i = 0; i < eggsCount; i++)
            {
                var color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        red++;
                        if (red > max)
                        {
                            max = red;
                            maxColor = "red";
                        }
                        break;
                    case "orange":
                        orange++;
                        if (orange > max)
                        {
                            max = orange;
                            maxColor = "orange";
                        }
                        break;
                    case "blue":
                        blue++;
                        if (blue > max)
                        {
                            max = blue;
                            maxColor = "blue";
                        }
                        break;
                    case "green":
                        green++;
                        if (green > max)
                        {
                            max = green;
                            maxColor = "green";
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Red eggs: {red}");
            Console.WriteLine($"Orange eggs: {orange}");
            Console.WriteLine($"Blue eggs: {blue}");
            Console.WriteLine($"Green eggs: {green}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}
