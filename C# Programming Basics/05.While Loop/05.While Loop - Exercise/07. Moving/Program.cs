using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //кашоните са 1х1х1 метра


            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var spaceInNewApartament = length * width * height;
            var usedSpace = 0;
            var countOfBoxes = " ";

            while(usedSpace <= spaceInNewApartament && countOfBoxes!= "Done" )
            {
                countOfBoxes = Console.ReadLine();
                if (countOfBoxes == "Done")
                {
                    Console.WriteLine($"{spaceInNewApartament-usedSpace} Cubic meters left.");
                    return;
                }
                usedSpace += int.Parse(countOfBoxes);





            }
            if(usedSpace > spaceInNewApartament)
            {
                Console.WriteLine($"No more free space! You need {usedSpace-spaceInNewApartament} Cubic meters more.");
            }









        }
    }
}
