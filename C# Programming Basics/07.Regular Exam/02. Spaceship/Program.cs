using System;

namespace _02._Spaceship
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var heigth = double.Parse(Console.ReadLine());
            var averageHeightofAstonauts = double.Parse(Console.ReadLine());

            var volumeOfSpaceship = width * length * heigth;
            var roomForOneAstronaut = 2 * 2 * (averageHeightofAstonauts + 0.40);
            var astronautsCount = Math.Floor(volumeOfSpaceship / roomForOneAstronaut);

            if (astronautsCount >= 3 && astronautsCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronautsCount} astronauts.");
            }
            else if (astronautsCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
