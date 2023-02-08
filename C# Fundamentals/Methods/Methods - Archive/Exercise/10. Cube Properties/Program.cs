using System;

namespace _10._Cube_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            if (command == "face")
            {
                Console.WriteLine($"{FaceDiag(side):f2}");
            }else if (command == "space")
            {
                Console.WriteLine($"{SpaceDiag(side):f2}");
            }
            else if (command == "volume")
            {
                Console.WriteLine($"{Volume(side):f2}");
            }
            else if (command == "area")
            {
                Console.WriteLine($"{Area(side):f2}");
            }



        }
        static double FaceDiag(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
        static double SpaceDiag(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }
        static double Volume(double side)
        {
            return Math.Pow(side, 3);
        }
        static double Area(double side)
        {
            return 6*Math.Pow(side,2);
        }
    }
}
